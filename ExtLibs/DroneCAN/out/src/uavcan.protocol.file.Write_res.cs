
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace DroneCAN
{
    public partial class DroneCAN {

        public partial class uavcan_protocol_file_Write_res : IDroneCANSerialize
        {
            public static void encode_uavcan_protocol_file_Write_res(uavcan_protocol_file_Write_res msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool fdcan) {
                uint8_t[] buffer = new uint8_t[8];
                _encode_uavcan_protocol_file_Write_res(buffer, msg, chunk_cb, ctx, !fdcan);
            }

            public static uint32_t decode_uavcan_protocol_file_Write_res(CanardRxTransfer transfer, uavcan_protocol_file_Write_res msg, bool fdcan) {
                uint32_t bit_ofs = 0;
                _decode_uavcan_protocol_file_Write_res(transfer, ref bit_ofs, msg, !fdcan);
                return (bit_ofs+7)/8;
            }

            internal static void _encode_uavcan_protocol_file_Write_res(uint8_t[] buffer, uavcan_protocol_file_Write_res msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool tao) {
                uavcan_protocol_file_Error._encode_uavcan_protocol_file_Error(buffer, msg.error, chunk_cb, ctx, tao);
            }

            internal static void _decode_uavcan_protocol_file_Write_res(CanardRxTransfer transfer,ref uint32_t bit_ofs, uavcan_protocol_file_Write_res msg, bool tao) {

                uavcan_protocol_file_Error._decode_uavcan_protocol_file_Error(transfer, ref bit_ofs, msg.error, tao);

            }
        }
    }
}