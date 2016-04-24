Just before i forget it again:

1. calculate unique id (based on get GetSourceModIndex)

2. client code:
```
set mutex.requestId <id>
setStage mutex 1 (attempt lock)
if mutex.lockId == <id>
   ; critical code
   setStage mutex 0 (free lock)
endif
```

3. mutex code:
stage 0:
```
set lockId to -1
```
stage 1:
```
if lockId == -1
  set lockId to requestId
endif
```