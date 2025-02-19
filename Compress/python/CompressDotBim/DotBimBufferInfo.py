# automatically generated by the FlatBuffers compiler, do not modify

# namespace: CompressDotBim

import flatbuffers
from flatbuffers.compat import import_numpy
np = import_numpy()

class DotBimBufferInfo(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAs(cls, buf, offset=0):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = DotBimBufferInfo()
        x.Init(buf, n + offset)
        return x

    @classmethod
    def GetRootAsDotBimBufferInfo(cls, buf, offset=0):
        """This method is deprecated. Please switch to GetRootAs."""
        return cls.GetRootAs(buf, offset)
    # DotBimBufferInfo
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # DotBimBufferInfo
    def Key(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return None

    # DotBimBufferInfo
    def Value(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return None

def DotBimBufferInfoStart(builder):
    builder.StartObject(2)

def Start(builder):
    DotBimBufferInfoStart(builder)

def DotBimBufferInfoAddKey(builder, key):
    builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(key), 0)

def AddKey(builder, key):
    DotBimBufferInfoAddKey(builder, key)

def DotBimBufferInfoAddValue(builder, value):
    builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(value), 0)

def AddValue(builder, value):
    DotBimBufferInfoAddValue(builder, value)

def DotBimBufferInfoEnd(builder):
    return builder.EndObject()

def End(builder):
    return DotBimBufferInfoEnd(builder)
