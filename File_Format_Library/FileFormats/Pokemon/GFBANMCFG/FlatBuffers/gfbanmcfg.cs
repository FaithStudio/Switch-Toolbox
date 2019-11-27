﻿// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatBuffers.Gfbanmcfg
{

    using global::System;
    using global::FlatBuffers;

    public struct AnimationConfig : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static AnimationConfig GetRootAsAnimationConfig(ByteBuffer _bb) { return GetRootAsAnimationConfig(_bb, new AnimationConfig()); }
        public static AnimationConfig GetRootAsAnimationConfig(ByteBuffer _bb, AnimationConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public AnimationConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public PartList? Parts { get { int o = __p.__offset(4); return o != 0 ? (PartList?)(new PartList()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
        public FloatingList? FloatList { get { int o = __p.__offset(6); return o != 0 ? (FloatingList?)(new FloatingList()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
        public int Unkown { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
        public int Unkown2 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
        public StateList? States { get { int o = __p.__offset(12); return o != 0 ? (StateList?)(new StateList()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
        public Initial? Initial { get { int o = __p.__offset(14); return o != 0 ? (Initial?)(new Initial()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
        public AnimationList? Animations { get { int o = __p.__offset(16); return o != 0 ? (AnimationList?)(new AnimationList()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

        public static Offset<AnimationConfig> CreateAnimationConfig(FlatBufferBuilder builder,
            Offset<PartList> PartsOffset = default(Offset<PartList>),
            Offset<FloatingList> FloatListOffset = default(Offset<FloatingList>),
            int Unkown = 0,
            int Unkown2 = 0,
            Offset<StateList> StatesOffset = default(Offset<StateList>),
            Offset<Initial> InitialOffset = default(Offset<Initial>),
            Offset<AnimationList> AnimationsOffset = default(Offset<AnimationList>))
        {
            builder.StartObject(7);
            AnimationConfig.AddAnimations(builder, AnimationsOffset);
            AnimationConfig.AddInitial(builder, InitialOffset);
            AnimationConfig.AddStates(builder, StatesOffset);
            AnimationConfig.AddUnkown2(builder, Unkown2);
            AnimationConfig.AddUnkown(builder, Unkown);
            AnimationConfig.AddFloatList(builder, FloatListOffset);
            AnimationConfig.AddParts(builder, PartsOffset);
            return AnimationConfig.EndAnimationConfig(builder);
        }

        public static void StartAnimationConfig(FlatBufferBuilder builder) { builder.StartObject(7); }
        public static void AddParts(FlatBufferBuilder builder, Offset<PartList> PartsOffset) { builder.AddOffset(0, PartsOffset.Value, 0); }
        public static void AddFloatList(FlatBufferBuilder builder, Offset<FloatingList> FloatListOffset) { builder.AddOffset(1, FloatListOffset.Value, 0); }
        public static void AddUnkown(FlatBufferBuilder builder, int Unkown) { builder.AddInt(2, Unkown, 0); }
        public static void AddUnkown2(FlatBufferBuilder builder, int Unkown2) { builder.AddInt(3, Unkown2, 0); }
        public static void AddStates(FlatBufferBuilder builder, Offset<StateList> StatesOffset) { builder.AddOffset(4, StatesOffset.Value, 0); }
        public static void AddInitial(FlatBufferBuilder builder, Offset<Initial> InitialOffset) { builder.AddOffset(5, InitialOffset.Value, 0); }
        public static void AddAnimations(FlatBufferBuilder builder, Offset<AnimationList> AnimationsOffset) { builder.AddOffset(6, AnimationsOffset.Value, 0); }
        public static Offset<AnimationConfig> EndAnimationConfig(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<AnimationConfig>(o);
        }
        public static void FinishAnimationConfigBuffer(FlatBufferBuilder builder, Offset<AnimationConfig> offset) { builder.Finish(offset.Value); }
        public static void FinishSizePrefixedAnimationConfigBuffer(FlatBufferBuilder builder, Offset<AnimationConfig> offset) { builder.FinishSizePrefixed(offset.Value); }
    };

    public struct StateList : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static StateList GetRootAsStateList(ByteBuffer _bb) { return GetRootAsStateList(_bb, new StateList()); }
        public static StateList GetRootAsStateList(ByteBuffer _bb, StateList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public StateList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


        public static void StartStateList(FlatBufferBuilder builder) { builder.StartObject(0); }
        public static Offset<StateList> EndStateList(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<StateList>(o);
        }
    };

    public struct Initial : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static Initial GetRootAsInitial(ByteBuffer _bb) { return GetRootAsInitial(_bb, new Initial()); }
        public static Initial GetRootAsInitial(ByteBuffer _bb, Initial obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public Initial __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


        public static void StartInitial(FlatBufferBuilder builder) { builder.StartObject(0); }
        public static Offset<Initial> EndInitial(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<Initial>(o);
        }
    };

    public struct FloatingList : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static FloatingList GetRootAsFloatingList(ByteBuffer _bb) { return GetRootAsFloatingList(_bb, new FloatingList()); }
        public static FloatingList GetRootAsFloatingList(ByteBuffer _bb, FloatingList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public FloatingList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


        public static void StartFloatingList(FlatBufferBuilder builder) { builder.StartObject(0); }
        public static Offset<FloatingList> EndFloatingList(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<FloatingList>(o);
        }
    };

    public struct AnimationList : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static AnimationList GetRootAsAnimationList(ByteBuffer _bb) { return GetRootAsAnimationList(_bb, new AnimationList()); }
        public static AnimationList GetRootAsAnimationList(ByteBuffer _bb, AnimationList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public AnimationList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public AnimationRef? Animations(int j) { int o = __p.__offset(4); return o != 0 ? (AnimationRef?)(new AnimationRef()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
        public int AnimationsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

        public static Offset<AnimationList> CreateAnimationList(FlatBufferBuilder builder,
            VectorOffset AnimationsOffset = default(VectorOffset))
        {
            builder.StartObject(1);
            AnimationList.AddAnimations(builder, AnimationsOffset);
            return AnimationList.EndAnimationList(builder);
        }

        public static void StartAnimationList(FlatBufferBuilder builder) { builder.StartObject(1); }
        public static void AddAnimations(FlatBufferBuilder builder, VectorOffset AnimationsOffset) { builder.AddOffset(0, AnimationsOffset.Value, 0); }
        public static VectorOffset CreateAnimationsVector(FlatBufferBuilder builder, Offset<AnimationRef>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
        public static VectorOffset CreateAnimationsVectorBlock(FlatBufferBuilder builder, Offset<AnimationRef>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
        public static void StartAnimationsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
        public static Offset<AnimationList> EndAnimationList(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<AnimationList>(o);
        }
    };

    public struct AnimationRef : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static AnimationRef GetRootAsAnimationRef(ByteBuffer _bb) { return GetRootAsAnimationRef(_bb, new AnimationRef()); }
        public static AnimationRef GetRootAsAnimationRef(ByteBuffer _bb, AnimationRef obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public AnimationRef __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span(4); }
#else
        public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
        public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
        public string File { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFileBytes() { return __p.__vector_as_span(6); }
#else
        public ArraySegment<byte>? GetFileBytes() { return __p.__vector_as_arraysegment(6); }
#endif
        public byte[] GetFileArray() { return __p.__vector_as_array<byte>(6); }

        public static Offset<AnimationRef> CreateAnimationRef(FlatBufferBuilder builder,
            StringOffset NameOffset = default(StringOffset),
            StringOffset FileOffset = default(StringOffset))
        {
            builder.StartObject(2);
            AnimationRef.AddFile(builder, FileOffset);
            AnimationRef.AddName(builder, NameOffset);
            return AnimationRef.EndAnimationRef(builder);
        }

        public static void StartAnimationRef(FlatBufferBuilder builder) { builder.StartObject(2); }
        public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(0, NameOffset.Value, 0); }
        public static void AddFile(FlatBufferBuilder builder, StringOffset FileOffset) { builder.AddOffset(1, FileOffset.Value, 0); }
        public static Offset<AnimationRef> EndAnimationRef(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<AnimationRef>(o);
        }
    };

    public struct PartList : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static PartList GetRootAsPartList(ByteBuffer _bb) { return GetRootAsPartList(_bb, new PartList()); }
        public static PartList GetRootAsPartList(ByteBuffer _bb, PartList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public PartList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


        public static void StartPartList(FlatBufferBuilder builder) { builder.StartObject(0); }
        public static Offset<PartList> EndPartList(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<PartList>(o);
        }
    };

    public struct Part : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static Part GetRootAsPart(ByteBuffer _bb) { return GetRootAsPart(_bb, new Part()); }
        public static Part GetRootAsPart(ByteBuffer _bb, Part obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public Part __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public int ID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
        public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span(6); }
#else
        public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
        public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
        public ModelRef? Objects { get { int o = __p.__offset(8); return o != 0 ? (ModelRef?)(new ModelRef()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

        public static Offset<Part> CreatePart(FlatBufferBuilder builder,
            int ID = 0,
            StringOffset NameOffset = default(StringOffset),
            Offset<ModelRef> ObjectsOffset = default(Offset<ModelRef>))
        {
            builder.StartObject(3);
            Part.AddObjects(builder, ObjectsOffset);
            Part.AddName(builder, NameOffset);
            Part.AddID(builder, ID);
            return Part.EndPart(builder);
        }

        public static void StartPart(FlatBufferBuilder builder) { builder.StartObject(3); }
        public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
        public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
        public static void AddObjects(FlatBufferBuilder builder, Offset<ModelRef> ObjectsOffset) { builder.AddOffset(2, ObjectsOffset.Value, 0); }
        public static Offset<Part> EndPart(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<Part>(o);
        }
    };

    public struct PartEffect : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static PartEffect GetRootAsPartEffect(ByteBuffer _bb) { return GetRootAsPartEffect(_bb, new PartEffect()); }
        public static PartEffect GetRootAsPartEffect(ByteBuffer _bb, PartEffect obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public PartEffect __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public int Empty { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

        public static Offset<PartEffect> CreatePartEffect(FlatBufferBuilder builder,
            int empty = 0)
        {
            builder.StartObject(1);
            PartEffect.AddEmpty(builder, empty);
            return PartEffect.EndPartEffect(builder);
        }

        public static void StartPartEffect(FlatBufferBuilder builder) { builder.StartObject(1); }
        public static void AddEmpty(FlatBufferBuilder builder, int empty) { builder.AddInt(0, empty, 0); }
        public static Offset<PartEffect> EndPartEffect(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<PartEffect>(o);
        }
    };

    public struct ModelRef : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static ModelRef GetRootAsModelRef(ByteBuffer _bb) { return GetRootAsModelRef(_bb, new ModelRef()); }
        public static ModelRef GetRootAsModelRef(ByteBuffer _bb, ModelRef obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public ModelRef __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public StringList? Bones { get { int o = __p.__offset(4); return o != 0 ? (StringList?)(new StringList()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

        public static Offset<ModelRef> CreateModelRef(FlatBufferBuilder builder,
            Offset<StringList> BonesOffset = default(Offset<StringList>))
        {
            builder.StartObject(1);
            ModelRef.AddBones(builder, BonesOffset);
            return ModelRef.EndModelRef(builder);
        }

        public static void StartModelRef(FlatBufferBuilder builder) { builder.StartObject(1); }
        public static void AddBones(FlatBufferBuilder builder, Offset<StringList> BonesOffset) { builder.AddOffset(0, BonesOffset.Value, 0); }
        public static Offset<ModelRef> EndModelRef(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<ModelRef>(o);
        }
    };

    public struct StringList : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static StringList GetRootAsStringList(ByteBuffer _bb) { return GetRootAsStringList(_bb, new StringList()); }
        public static StringList GetRootAsStringList(ByteBuffer _bb, StringList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public StringList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public sbyte Unknown { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public string List(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
        public int ListLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

        public static Offset<StringList> CreateStringList(FlatBufferBuilder builder,
            sbyte Unknown = 0,
            VectorOffset ListOffset = default(VectorOffset))
        {
            builder.StartObject(2);
            StringList.AddList(builder, ListOffset);
            StringList.AddUnknown(builder, Unknown);
            return StringList.EndStringList(builder);
        }

        public static void StartStringList(FlatBufferBuilder builder) { builder.StartObject(2); }
        public static void AddUnknown(FlatBufferBuilder builder, sbyte Unknown) { builder.AddSbyte(0, Unknown, 0); }
        public static void AddList(FlatBufferBuilder builder, VectorOffset ListOffset) { builder.AddOffset(1, ListOffset.Value, 0); }
        public static VectorOffset CreateListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
        public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
        public static void StartListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
        public static Offset<StringList> EndStringList(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();
            return new Offset<StringList>(o);
        }
    };

    public struct Vector3 : IFlatbufferObject
    {
        private Struct __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public Vector3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
        public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
        public float Z { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }

        public static Offset<Vector3> CreateVector3(FlatBufferBuilder builder, float X, float Y, float Z)
        {
            builder.Prep(4, 12);
            builder.PutFloat(Z);
            builder.PutFloat(Y);
            builder.PutFloat(X);
            return new Offset<Vector3>(builder.Offset);
        }
    };

    public struct Vector4 : IFlatbufferObject
    {
        private Struct __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public Vector4 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
        public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
        public float Z { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }
        public float W { get { return __p.bb.GetFloat(__p.bb_pos + 12); } }

        public static Offset<Vector4> CreateVector4(FlatBufferBuilder builder, float X, float Y, float Z, float W)
        {
            builder.Prep(4, 16);
            builder.PutFloat(W);
            builder.PutFloat(Z);
            builder.PutFloat(Y);
            builder.PutFloat(X);
            return new Offset<Vector4>(builder.Offset);
        }
    };

    public struct Quaternion : IFlatbufferObject
    {
        private Struct __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public Quaternion __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public ushort X { get { return __p.bb.GetUshort(__p.bb_pos + 0); } }
        public ushort Y { get { return __p.bb.GetUshort(__p.bb_pos + 2); } }
        public ushort Z { get { return __p.bb.GetUshort(__p.bb_pos + 4); } }

        public static Offset<Quaternion> CreateQuaternion(FlatBufferBuilder builder, ushort X, ushort Y, ushort Z)
        {
            builder.Prep(2, 6);
            builder.PutUshort(Z);
            builder.PutUshort(Y);
            builder.PutUshort(X);
            return new Offset<Quaternion>(builder.Offset);
        }
    };

    public struct SRT : IFlatbufferObject
    {
        private Struct __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
        public SRT __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public float ScaleX { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
        public float ScaleY { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
        public float ScaleZ { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }
        public float RotateX { get { return __p.bb.GetFloat(__p.bb_pos + 12); } }
        public float RotateY { get { return __p.bb.GetFloat(__p.bb_pos + 16); } }
        public float RotateZ { get { return __p.bb.GetFloat(__p.bb_pos + 20); } }
        public float RotateW { get { return __p.bb.GetFloat(__p.bb_pos + 24); } }
        public float TranslateX { get { return __p.bb.GetFloat(__p.bb_pos + 28); } }
        public float TranslateY { get { return __p.bb.GetFloat(__p.bb_pos + 32); } }
        public float TranslateZ { get { return __p.bb.GetFloat(__p.bb_pos + 36); } }

        public static Offset<SRT> CreateSRT(FlatBufferBuilder builder, float ScaleX, float ScaleY, float ScaleZ, float RotateX, float RotateY, float RotateZ, float RotateW, float TranslateX, float TranslateY, float TranslateZ)
        {
            builder.Prep(4, 40);
            builder.PutFloat(TranslateZ);
            builder.PutFloat(TranslateY);
            builder.PutFloat(TranslateX);
            builder.PutFloat(RotateW);
            builder.PutFloat(RotateZ);
            builder.PutFloat(RotateY);
            builder.PutFloat(RotateX);
            builder.PutFloat(ScaleZ);
            builder.PutFloat(ScaleY);
            builder.PutFloat(ScaleX);
            return new Offset<SRT>(builder.Offset);
        }
    };


}
