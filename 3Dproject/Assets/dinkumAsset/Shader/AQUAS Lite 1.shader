//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "AQUAS Lite 1" {
Properties {
_NormalTexture ("Normal Texture", 2D) = "white" { }
_NormalTiling ("Normal Tiling", Float) = 1
_MainColor ("Main Color", Color) = (0,0.4627451,1,1)
_DeepWaterColor ("Deep Water Color", Color) = (0,0.3411765,0.6235294,1)
_Fade ("Fade", Float) = 1.45
_Density ("Density", Range(0, 10)) = 1.74
_DepthTransparency ("Depth Transparency", Float) = 1.5
_ShoreFade ("Shore Fade", Float) = 0.3
_ShoreTransparency ("Shore Transparency", Float) = 0.04
[MaterialToggle] _EnableReflections ("Enable Reflections", Float) = 0
_ReflectionTex ("Reflection Tex", 2D) = "white" { }
_ReflectionIntensity ("Reflection Intensity", Range(0, 1)) = 0.6
_Distortion ("Distortion", Range(0, 2)) = 0.3
_Specular ("Specular", Float) = 1
_SpecularColor ("Specular Color", Color) = (0.6985294,0.7088019,0.7088019,1)
_Gloss ("Gloss", Float) = 0.7
_LightWrapping ("Light Wrapping", Float) = 2
_Refraction ("Refraction", Range(0, 1)) = 0.67
_WaveSpeed ("Wave Speed", Float) = 40
_FoamTexture ("Foam Texture", 2D) = "white" { }
_FoamTiling ("Foam Tiling", Float) = 3
_FoamBlend ("Foam Blend", Float) = 0.15
_FoamVisibility ("Foam Visibility", Range(0, 1)) = 0.3
_FoamIntensity ("Foam Intensity", Float) = 10
_FoamContrast ("Foam Contrast", Range(0, 0.5)) = 0.25
_FoamColor ("Foam Color", Color) = (0.3382353,0.3456964,0.3456964,1)
_FoamSpeed ("Foam Speed", Float) = 120
[MaterialToggle] _EnableCustomFog ("Enable Custom Fog", Float) = 2.860078
_FogColor ("Fog Color", Color) = (1,1,1,1)
_FogDistance ("Fog Distance", Float) = 1000
_FogFade ("Fog Fade", Float) = 1
_RefractionDistance ("Refraction Distance", Float) = 10
_RefractionFalloff ("Refraction Falloff", Float) = 1
_Darkness ("Darkness", Float) = 1
_Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
}
SubShader {
 Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
 GrabPass {
  "Refraction"
}
 Pass {
  Name "DEFERRED"
  Tags { "IGNOREPROJECTOR" = "true" "LIGHTMODE" = "FORWARDBASE" "QUEUE" = "Transparent" "RenderType" = "Transparent" "SHADOWSUPPORT" = "true" }
  Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
  ZWrite Off
  GpuProgramID 25786
Program "vp" {
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "LIGHTPROBE_SH" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "LIGHTPROBE_SH" "SHADOWS_SCREEN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "VERTEXLIGHT_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "LIGHTPROBE_SH" "VERTEXLIGHT_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" "VERTEXLIGHT_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "LIGHTPROBE_SH" "SHADOWS_SCREEN" "VERTEXLIGHT_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "LIGHTPROBE_SH" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "SHADOWS_SCREEN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "LIGHTPROBE_SH" "SHADOWS_SCREEN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "VERTEXLIGHT_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "LIGHTPROBE_SH" "VERTEXLIGHT_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "SHADOWS_SCREEN" "VERTEXLIGHT_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "LIGHTPROBE_SH" "SHADOWS_SCREEN" "VERTEXLIGHT_ON" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "LIGHTPROBE_SH" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "LIGHTPROBE_SH" "SHADOWS_SCREEN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "LIGHTPROBE_SH" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "SHADOWS_SCREEN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "DIRECTIONAL" "FOG_LINEAR" "LIGHTPROBE_SH" "SHADOWS_SCREEN" }
"// shader disassembly not supported on DXBC"
}
}
}
}
Fallback "Diffuse"
}