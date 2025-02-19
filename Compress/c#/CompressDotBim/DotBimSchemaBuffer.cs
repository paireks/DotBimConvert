// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace CompressDotBim
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct DotBimSchemaBuffer : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static DotBimSchemaBuffer GetRootAsDotBimSchemaBuffer(ByteBuffer _bb) { return GetRootAsDotBimSchemaBuffer(_bb, new DotBimSchemaBuffer()); }
  public static DotBimSchemaBuffer GetRootAsDotBimSchemaBuffer(ByteBuffer _bb, DotBimSchemaBuffer obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool VerifyDotBimSchemaBuffer(ByteBuffer _bb) {Google.FlatBuffers.Verifier verifier = new Google.FlatBuffers.Verifier(_bb); return verifier.VerifyBuffer("", false, DotBimSchemaBufferVerify.Verify); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DotBimSchemaBuffer __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Schemaversion { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSchemaversionBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetSchemaversionBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetSchemaversionArray() { return __p.__vector_as_array<byte>(4); }
  public string Info { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInfoBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetInfoBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetInfoArray() { return __p.__vector_as_array<byte>(6); }
  public CompressDotBim.DotBimBufferMeshes? Meshes(int j) { int o = __p.__offset(8); return o != 0 ? (CompressDotBim.DotBimBufferMeshes?)(new CompressDotBim.DotBimBufferMeshes()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int MeshesLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public CompressDotBim.DotBimBufferElement? Elements(int j) { int o = __p.__offset(10); return o != 0 ? (CompressDotBim.DotBimBufferElement?)(new CompressDotBim.DotBimBufferElement()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ElementsLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<CompressDotBim.DotBimSchemaBuffer> CreateDotBimSchemaBuffer(FlatBufferBuilder builder,
      StringOffset schemaversionOffset = default(StringOffset),
      StringOffset infoOffset = default(StringOffset),
      VectorOffset meshesOffset = default(VectorOffset),
      VectorOffset elementsOffset = default(VectorOffset)) {
    builder.StartTable(4);
    DotBimSchemaBuffer.AddElements(builder, elementsOffset);
    DotBimSchemaBuffer.AddMeshes(builder, meshesOffset);
    DotBimSchemaBuffer.AddInfo(builder, infoOffset);
    DotBimSchemaBuffer.AddSchemaversion(builder, schemaversionOffset);
    return DotBimSchemaBuffer.EndDotBimSchemaBuffer(builder);
  }

  public static void StartDotBimSchemaBuffer(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddSchemaversion(FlatBufferBuilder builder, StringOffset schemaversionOffset) { builder.AddOffset(0, schemaversionOffset.Value, 0); }
  public static void AddInfo(FlatBufferBuilder builder, StringOffset infoOffset) { builder.AddOffset(1, infoOffset.Value, 0); }
  public static void AddMeshes(FlatBufferBuilder builder, VectorOffset meshesOffset) { builder.AddOffset(2, meshesOffset.Value, 0); }
  public static VectorOffset CreateMeshesVector(FlatBufferBuilder builder, Offset<CompressDotBim.DotBimBufferMeshes>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateMeshesVectorBlock(FlatBufferBuilder builder, Offset<CompressDotBim.DotBimBufferMeshes>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMeshesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CompressDotBim.DotBimBufferMeshes>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMeshesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<CompressDotBim.DotBimBufferMeshes>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMeshesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddElements(FlatBufferBuilder builder, VectorOffset elementsOffset) { builder.AddOffset(3, elementsOffset.Value, 0); }
  public static VectorOffset CreateElementsVector(FlatBufferBuilder builder, Offset<CompressDotBim.DotBimBufferElement>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateElementsVectorBlock(FlatBufferBuilder builder, Offset<CompressDotBim.DotBimBufferElement>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateElementsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CompressDotBim.DotBimBufferElement>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateElementsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<CompressDotBim.DotBimBufferElement>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartElementsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<CompressDotBim.DotBimSchemaBuffer> EndDotBimSchemaBuffer(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<CompressDotBim.DotBimSchemaBuffer>(o);
  }
  public static void FinishDotBimSchemaBufferBuffer(FlatBufferBuilder builder, Offset<CompressDotBim.DotBimSchemaBuffer> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedDotBimSchemaBufferBuffer(FlatBufferBuilder builder, Offset<CompressDotBim.DotBimSchemaBuffer> offset) { builder.FinishSizePrefixed(offset.Value); }
}


static public class DotBimSchemaBufferVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Schemaversion*/, false)
      && verifier.VerifyString(tablePos, 6 /*Info*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 8 /*Meshes*/, CompressDotBim.DotBimBufferMeshesVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 10 /*Elements*/, CompressDotBim.DotBimBufferElementVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
