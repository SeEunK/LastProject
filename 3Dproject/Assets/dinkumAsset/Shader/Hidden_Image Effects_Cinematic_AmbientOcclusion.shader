//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Image Effects/Cinematic/AmbientOcclusion" {
Properties {
_MainTex ("", 2D) = "" { }
_OcclusionTexture ("", 2D) = "" { }
}
SubShader {
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 30232
Program "vp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 124033
Program "vp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 188827
Program "vp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Blend Zero OneMinusSrcColor, Zero OneMinusSrcAlpha
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 244529
Program "vp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 312388
Program "vp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_DEPTHNORMALS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SAMPLECOUNT_LOWEST" "_SOURCE_GBUFFER" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}