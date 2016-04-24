GameForms.h

```
// BGSExplosion (A8)
class BGSExplosion : public TESBoundObject
{
public:
	BGSExplosion();
	~BGSExplosion();

	TESFullName					fullName;			// 030
	TESModel					model;				// 03C
	TESEnchantableForm			enchantable;		// 054
	BGSPreloadable				preloadable;		// 064
	TESImageSpaceModifiableForm	imageSpaceModForm;	// 068

	TESBoundObject*						placedObject;				// 070
	float force;	// 074
	float damage;	// 078
	float radius; // 07C
	TESObjectLIGH* light; // 080
	TESSound* sound1; // 084
	UInt32 unk088; // 088
	float unk08C; // 08C
	BGSImpactDataSet* impactDataSet; // 090
	TESSound* sound2; // 094
	float unk098; // 098
	float unk09C; // 09C
	float unk0A0; // 0A0
	UInt32 unk0A4; // 0A4
};

STATIC_ASSERT(sizeof(BGSExplosion) == 0xA8);

// 0C0
class BGSProjectile : public TESBoundObject
{
public:
	BGSProjectile();
	~BGSProjectile();

	// bases
	TESFullName					fullName;		// 030
	TESModel					model;			// 03C
	BGSPreloadable				preloadable;	// 054
	BGSDestructibleObjectForm	destructible;	// 058

	UInt32	unk060[(0x84-0x60) >> 2];			// 060

	BGSExplosion*				explosion;		// 084

	UInt32	unk088[(0xC0-0x88) >> 2];			// 088
};
```