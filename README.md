# [KamaliTransition](https://twitter.com/ShaderGuy/status/1220922020701114368?s=20)

I do this by using [stencil buffer](https://docs.unity3d.com/Manual/SL-Stencil.html)

![Record_2020_01_25_23_27_26_68](https://user-images.githubusercontent.com/16706911/73126623-529a2980-3fca-11ea-85e2-104ffad18a29.gif)


Stencil Op/Comparison Values

# Comparison Functions

```
0 - Always
1 - Never
2 - Less
3 - Equal
4 - LEqual
5 - Greater
6 - NotEqual
7 - GEqual
8 - Always // (This is the default for the UI shaders so I suspect this one is technically the 'correct' Always, but any value beyond it will also count as Always)
```

# Stencil Operations

```
0 - Keep
1 - Zero
2 - Replace
3 - IncrSat
4 - DecrSat
5 - Invert
6 - IncrWrap
7 - DecrWrap
```

References:

[unity forum](https://forum.unity.com/threads/stencil-op-comparison-values.362425/) & [khronos](https://www.khronos.org/registry/vulkan/specs/1.1-extensions/man/html/VkStencilOp.html)

I explained more about UI [stencil Buffer here](https://gamedev.stackexchange.com/questions/158128/how-to-write-a-transparent-shader-for-a-sprite-that-ignores-transparent-sprites/158132#158132)


# Adding Enum to Inspector

change your properties like this:
```
[Enum(UnityEngine.Rendering.CompareFunction)] _StencilComp ("Stencil Comparison", Int) = 0
[Enum(UnityEngine.Rendering.StencilOp)] _StencilOp ("Stencil Operation", Int) = 0
```
____________________

# Mask Material

![image](https://user-images.githubusercontent.com/16706911/73126700-1d420b80-3fcb-11ea-89ce-8c735ad53e93.png)

# Foreground UI Material

![image](https://user-images.githubusercontent.com/16706911/73126731-64300100-3fcb-11ea-8f6a-323ee4883756.png)

# Masking TextMeshpro
I explained here how to mask [Textmesh pro](https://gamedev.stackexchange.com/questions/176170/how-to-use-a-sprite-mask-or-shader-to-mask-a-text
)

![image](https://user-images.githubusercontent.com/16706911/73126746-a2c5bb80-3fcb-11ea-919f-f5566a7c8302.png)

