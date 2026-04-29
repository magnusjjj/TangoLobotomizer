import ctypes
import os
import struct

from NoitaStream import NoitaStream

class FastLZ:
    windows:bool = os.name == "nt"
    fastlz:ctypes.CDLL = ctypes.cdll.LoadLibrary("./fastlz.dll" if windows else "./fastlz.so")
    def Decode(self, buffer:bytes) -> bytes:
        compressed_size,decompressed_size = struct.unpack("<II", buffer[0:8])
        input_buffer = ctypes.create_string_buffer(buffer[8:], compressed_size)
        output_buffer = ctypes.create_string_buffer(decompressed_size)
        self.fastlz.fastlz_decompress.restype = ctypes.c_int32
        self.fastlz.fastlz_decompress(input_buffer, compressed_size, output_buffer, decompressed_size)
        return b"".join([x for x in output_buffer])
    def Encode(self, buffer:bytes) -> bytes:
        raise Exception("test")
        pass


