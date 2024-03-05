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

namespace DroneCAN
{
    public partial class DroneCAN 
    {
        public partial class uavcan_equipment_air_data_StaticPressure: IDroneCANSerialize 
        {
            public const int UAVCAN_EQUIPMENT_AIR_DATA_STATICPRESSURE_MAX_PACK_SIZE = 6;
            public const ulong UAVCAN_EQUIPMENT_AIR_DATA_STATICPRESSURE_DT_SIG = 0xCDC7C43412BDC89A;
            public const int UAVCAN_EQUIPMENT_AIR_DATA_STATICPRESSURE_DT_ID = 1028;

            public Single static_pressure = new Single();
            public Single static_pressure_variance = new Single();

            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool fdcan = false)
            {
                encode_uavcan_equipment_air_data_StaticPressure(this, chunk_cb, ctx, fdcan);
            }

            public void decode(CanardRxTransfer transfer, bool fdcan = false)
            {
                decode_uavcan_equipment_air_data_StaticPressure(transfer, this, fdcan);
            }

            public static uavcan_equipment_air_data_StaticPressure ByteArrayToDroneCANMsg(byte[] transfer, int startoffset, bool fdcan = false)
            {
                var ans = new uavcan_equipment_air_data_StaticPressure();
                ans.decode(new DroneCAN.CanardRxTransfer(transfer.Skip(startoffset).ToArray()), fdcan);
                return ans;
            }
        }
    }
}