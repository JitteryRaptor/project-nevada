
```

#include "nvse/PluginAPI.h"
#include "nvse/GameAPI.h"
#include "nvse/ParamInfos.h"
#include "nvse/GameObjects.h"
#include "nvse/GameRTTI.h"
#include "nvse/GameForms.h"
#include "nvse/SafeWrite.h"

IDebugLog		gLog("pn_nvse.log");

PluginHandle				g_pluginHandle = kPluginHandle_Invalid;

/**********************
* Hooks
**********************/

UInt32 *hookConditionDamagePenalty = (UInt32*)0x00646D25;

/**********************
* Patched globals
**********************/

double conditionDamagePenalty = 0.6700000166893005;

/**********************
* Command handlers
**********************/

static ParamInfo PN_kParamType_OneOptionalActorBase[1] =
{
	{ "actor base",	kParamType_ActorBase,	1 }
};

bool Cmd_PN_GetProjectileExplosion_Execute(COMMAND_ARGS)
{
	*result = 0;
	TESForm* pForm = 0;
	
	if(!ExtractArgsEx(EXTRACT_ARGS_EX, &pForm)) return true;
	pForm = pForm->TryGetREFRParent();
	if (!pForm) {
		if (!thisObj) return true;
		pForm = thisObj->baseForm;
	}

	BGSProjectile* pProj = DYNAMIC_CAST(pForm, TESForm, BGSProjectile);
	if (pProj) {
		BGSExplosion* pExplosion = pProj->explosion;
		if (pExplosion) {
			*((UInt32*)result) = pExplosion->refID;
		}
	}

	return true;
}

bool Cmd_PN_GetExplosionDamage_Execute(COMMAND_ARGS)
{
	*result = 0;
	TESForm* pForm = 0;
	
	if(!ExtractArgsEx(EXTRACT_ARGS_EX, &pForm)) return true;
	pForm = pForm->TryGetREFRParent();
	if (!pForm) {
		if (!thisObj) return true;
		pForm = thisObj->baseForm;
	}

	BGSExplosion* pExplosion = DYNAMIC_CAST(pForm, TESForm, BGSExplosion);
	if (pExplosion) {
		*result = pExplosion->damage;
	}

	return true;
}

bool Cmd_PN_SetExplosionDamage_Execute(COMMAND_ARGS)
{
	*result = 0;
	float floatVal = 0.0;
	TESForm* pForm = 0;
	if (!ExtractArgsEx(EXTRACT_ARGS_EX, &floatVal, &pForm)) return true;
	
	pForm = pForm->TryGetREFRParent();
	if (!pForm) {
		if (!thisObj) return true;
		pForm = thisObj->baseForm;
	}

	BGSExplosion* pExplosion = DYNAMIC_CAST(pForm, TESForm, BGSExplosion);
	if (pExplosion) {
		pExplosion->damage = floatVal;
	}

	return true;
}

bool Cmd_PN_GetExplosionForce_Execute(COMMAND_ARGS)
{
	*result = 0;
	TESForm* pForm = 0;
	
	if(!ExtractArgsEx(EXTRACT_ARGS_EX, &pForm)) return true;
	pForm = pForm->TryGetREFRParent();
	if (!pForm) {
		if (!thisObj) return true;
		pForm = thisObj->baseForm;
	}

	BGSExplosion* pExplosion = DYNAMIC_CAST(pForm, TESForm, BGSExplosion);
	if (pExplosion) {
		*result = pExplosion->force;
	}

	return true;
}

bool Cmd_PN_SetExplosionForce_Execute(COMMAND_ARGS)
{
	*result = 0;
	float floatVal = 0.0;
	TESForm* pForm = 0;
	if (!ExtractArgsEx(EXTRACT_ARGS_EX, &floatVal, &pForm)) return true;
	
	pForm = pForm->TryGetREFRParent();
	if (!pForm) {
		if (!thisObj) return true;
		pForm = thisObj->baseForm;
	}

	BGSExplosion* pExplosion = DYNAMIC_CAST(pForm, TESForm, BGSExplosion);
	if (pExplosion) {
		pExplosion->force = floatVal;
	}

	return true;
}

bool Cmd_PN_ListClear_Execute(COMMAND_ARGS)
{
	*result = 0;
	BGSListForm* pListForm = NULL;
	if (!ExtractArgsEx(EXTRACT_ARGS_EX, &pListForm)) return true;

	if (pListForm) {
		pListForm->list.RemoveAll();
	}
	return true;
}

bool Cmd_PN_GetActorBaseFlagsLow_Execute(COMMAND_ARGS)
{
	TESActorBase	* obj = NULL;

	*result = 0;

	if(!ExtractArgs(EXTRACT_ARGS, &obj)) return true;

	if(!obj && thisObj && thisObj->baseForm)
		obj = DYNAMIC_CAST(thisObj->baseForm, TESForm, TESActorBase);

	if(obj) {
		TESActorBaseData* baseData = &obj->baseData;

		if(baseData)
			*result = baseData->flags & 0xFFFF;
	}

	return true;
}

bool Cmd_PN_SetConditionDamagePenalty_Execute(COMMAND_ARGS)
{
	*result = 0;

	float arg = 0;
	if (!ExtractArgs(EXTRACT_ARGS, &arg))
		return true;

	if (arg < 0 || arg > 1.0)
		return true;

	conditionDamagePenalty = arg;

	return true;
}

bool Cmd_PN_GetConditionDamagePenalty_Execute(COMMAND_ARGS)
{
	*result = conditionDamagePenalty;
	return true;
}


/**************************
* Command definitions
**************************/

// 1
DEFINE_COMMAND_PLUGIN(PN_GetProjectileExplosion, returns explosion of projectile, 0, 1, kParams_OneOptionalObjectID);
DEFINE_COMMAND_PLUGIN(PN_GetExplosionDamage, returns damage of explosion, 0, 1, kParams_OneOptionalObjectID);
DEFINE_COMMAND_PLUGIN(PN_GetExplosionForce, returns force of explosion, 0, 1, kParams_OneOptionalObjectID);
DEFINE_COMMAND_PLUGIN(PN_SetExplosionDamage, sets damage of explosion, 0, 2, kParams_OneFloat_OneOptionalObjectID);
DEFINE_COMMAND_PLUGIN(PN_SetExplosionForce, sets force of explosion, 0, 2, kParams_OneFloat_OneOptionalObjectID);
// 2
DEFINE_COMMAND_PLUGIN(PN_ListClear, deletes all elements in the list, 0, 1, kParams_FormList);
DEFINE_COMMAND_PLUGIN(PN_GetActorBaseFlagsLow, fixed function, 0, 1, PN_kParamType_OneOptionalActorBase);
DEFINE_COMMAND_PLUGIN(PN_SetConditionDamagePenalty, set the condition damage penalty, 0, 1, kParams_OneFloat);
DEFINE_COMMAND_PLUGIN(PN_GetConditionDamagePenalty, get the condition damage penalty, 0, 0, NULL);


extern "C" {

	__declspec(dllexport) bool NVSEPlugin_Query(const NVSEInterface * nvse, PluginInfo * info)
	{
		_MESSAGE("query");

		// fill out the info structure
		info->infoVersion = PluginInfo::kInfoVersion;
		info->name = "pn_nvse";
		info->version = 2;

		// version checks
		if(!nvse->isEditor)
		{
			if(nvse->nvseVersion < 0)
			{
				_ERROR("NVSE version too old (got %08X expected at least %08X)", nvse->nvseVersion, 0);
				return false;
			}
		}
		else
		{
			// no version checks needed for editor
		}

		// version checks pass

		return true;
	}

	__declspec(dllexport) bool NVSEPlugin_Load(const NVSEInterface * nvse)
	{
		_MESSAGE("load");

		g_pluginHandle = nvse->GetPluginHandle();
		
		if (*hookConditionDamagePenalty == 0x01051680) {
			_MESSAGE("installed hook for conditionDamagePenalty");
			SafeWrite32((UInt32)hookConditionDamagePenalty, (UInt32) &conditionDamagePenalty);
		}

		// register commands
		nvse->SetOpcodeBase(0x2125);

		nvse->RegisterCommand(&kCommandInfo_PN_GetProjectileExplosion);
		nvse->RegisterCommand(&kCommandInfo_PN_GetExplosionDamage);
		nvse->RegisterCommand(&kCommandInfo_PN_GetExplosionForce);
		nvse->RegisterCommand(&kCommandInfo_PN_SetExplosionDamage);
		nvse->RegisterCommand(&kCommandInfo_PN_SetExplosionForce);
		
		nvse->RegisterCommand(&kCommandInfo_PN_ListClear);
		nvse->RegisterCommand(&kCommandInfo_PN_GetActorBaseFlagsLow);
		nvse->RegisterCommand(&kCommandInfo_PN_SetConditionDamagePenalty);
		nvse->RegisterCommand(&kCommandInfo_PN_GetConditionDamagePenalty);

		_MESSAGE("registered commands");

		return true;
	}

};


```