using System.Collections;
using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public struct CharacterItemSockets : IEnumerable<int>
    {
        public int socket1;
        public int socket2;
        public int socket3;
        public int socket4;
        public int socket5;
        public int socket6;
        public int socket7;
        public int socket8;

#if SOCKET_ENHANCER_TYPES_16 || SOCKET_ENHANCER_TYPES_32
        public int socket9;
        public int socket10;
        public int socket11;
        public int socket12;
        public int socket13;
        public int socket14;
        public int socket15;
        public int socket16;
#endif

#if SOCKET_ENHANCER_TYPES_32
        public int socket17;
        public int socket18;
        public int socket19;
        public int socket20;
        public int socket21;
        public int socket22;
        public int socket23;
        public int socket24;
        public int socket25;
        public int socket26;
        public int socket27;
        public int socket28;
        public int socket29;
        public int socket30;
        public int socket31;
        public int socket32;
#endif

#if SOCKET_ENHANCER_TYPES_32
        public const int MAX_SOCKETS = 32;
#elif SOCKET_ENHANCER_TYPES_16
        public const int MAX_SOCKETS = 16;
#else
        public const int MAX_SOCKETS = 8;
#endif
        public int Count => MAX_SOCKETS;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return socket1;
                    case 1:
                        return socket2;
                    case 2:
                        return socket3;
                    case 3:
                        return socket4;
                    case 4:
                        return socket5;
                    case 5:
                        return socket6;
                    case 6:
                        return socket7;
                    case 7:
                        return socket8;

#if SOCKET_ENHANCER_TYPES_16 || SOCKET_ENHANCER_TYPES_32
                    case 8:
                        return socket9;
                    case 9:
                        return socket10;
                    case 10:
                        return socket11;
                    case 11:
                        return socket12;
                    case 12:
                        return socket13;
                    case 13:
                        return socket14;
                    case 14:
                        return socket15;
                    case 15:
                        return socket16;
#endif

#if SOCKET_ENHANCER_TYPES_32
                    case 16:
                        return socket17;
                    case 17:
                        return socket18;
                    case 18:
                        return socket19;
                    case 19:
                        return socket20;
                    case 20:
                        return socket21;
                    case 21:
                        return socket22;
                    case 22:
                        return socket23;
                    case 23:
                        return socket24;
                    case 24:
                        return socket25;
                    case 25:
                        return socket26;
                    case 26:
                        return socket27;
                    case 27:
                        return socket28;
                    case 28:
                        return socket29;
                    case 29:
                        return socket30;
                    case 30:
                        return socket31;
                    case 31:
                        return socket32;
#endif
                    default:
                        throw new System.IndexOutOfRangeException($"Invalid socket index: {index}");
                }
                ;
            }
            set
            {
                switch (index)
                {
                    case 0:
                        socket1 = value;
                        break;
                    case 1:
                        socket2 = value;
                        break;
                    case 2:
                        socket3 = value;
                        break;
                    case 3:
                        socket4 = value;
                        break;
                    case 4:
                        socket5 = value;
                        break;
                    case 5:
                        socket6 = value;
                        break;
                    case 6:
                        socket7 = value;
                        break;
                    case 7:
                        socket8 = value;
                        break;

#if SOCKET_ENHANCER_TYPES_16 || SOCKET_ENHANCER_TYPES_32
                    case 8:
                        socket9 = value;
                        break;
                    case 9:
                        socket10 = value;
                        break;
                    case 10:
                        socket11 = value;
                        break;
                    case 11:
                        socket12 = value;
                        break;
                    case 12:
                        socket13 = value;
                        break;
                    case 13:
                        socket14 = value;
                        break;
                    case 14:
                        socket15 = value;
                        break;
                    case 15:
                        socket16 = value;
                        break;
#endif

#if SOCKET_ENHANCER_TYPES_32
                    case 16:
                        socket17 = value;
                    case 17:
                        socket18 = value;
                    case 18:
                        socket19 = value;
                    case 19:
                        socket20 = value;
                    case 20:
                        socket21 = value;
                    case 21:
                        socket22 = value;
                    case 22:
                        socket23 = value;
                    case 23:
                        socket24 = value;
                    case 24:
                        socket25 = value;
                    case 25:
                        socket26 = value;
                    case 26:
                        socket27 = value;
                    case 27:
                        socket28 = value;
                    case 28:
                        socket29 = value;
                    case 29:
                        socket30 = value;
                    case 30:
                        socket31 = value;
                    case 31:
                        socket32 = value;
#endif
                    default:
                        throw new System.IndexOutOfRangeException($"Invalid socket index: {index}");
                }
            }
        }

        public CharacterItemSocketsSyncStates GetStates()
        {
            CharacterItemSocketsSyncStates states = CharacterItemSocketsSyncStates.None;
            states |= CharacterItemSocketsSyncStates.Socket1;
            states |= CharacterItemSocketsSyncStates.Socket2;
            states |= CharacterItemSocketsSyncStates.Socket3;
            states |= CharacterItemSocketsSyncStates.Socket4;
            states |= CharacterItemSocketsSyncStates.Socket5;
            states |= CharacterItemSocketsSyncStates.Socket6;
            states |= CharacterItemSocketsSyncStates.Socket7;
            states |= CharacterItemSocketsSyncStates.Socket8;

#if SOCKET_ENHANCER_TYPES_16 || SOCKET_ENHANCER_TYPES_32
            states |= CharacterItemSocketsSyncStates.Socket9;
            states |= CharacterItemSocketsSyncStates.Socket10;
            states |= CharacterItemSocketsSyncStates.Socket11;
            states |= CharacterItemSocketsSyncStates.Socket12;
            states |= CharacterItemSocketsSyncStates.Socket13;
            states |= CharacterItemSocketsSyncStates.Socket14;
            states |= CharacterItemSocketsSyncStates.Socket15;
            states |= CharacterItemSocketsSyncStates.Socket16;
#endif

#if SOCKET_ENHANCER_TYPES_32
            states |= CharacterItemSocketsSyncStates.Socket17;
            states |= CharacterItemSocketsSyncStates.Socket18;
            states |= CharacterItemSocketsSyncStates.Socket19;
            states |= CharacterItemSocketsSyncStates.Socket20;
            states |= CharacterItemSocketsSyncStates.Socket21;
            states |= CharacterItemSocketsSyncStates.Socket22;
            states |= CharacterItemSocketsSyncStates.Socket23;
            states |= CharacterItemSocketsSyncStates.Socket24;
            states |= CharacterItemSocketsSyncStates.Socket25;
            states |= CharacterItemSocketsSyncStates.Socket26;
            states |= CharacterItemSocketsSyncStates.Socket27;
            states |= CharacterItemSocketsSyncStates.Socket28;
            states |= CharacterItemSocketsSyncStates.Socket29;
            states |= CharacterItemSocketsSyncStates.Socket30;
            states |= CharacterItemSocketsSyncStates.Socket31;
            states |= CharacterItemSocketsSyncStates.Socket32;
#endif
            return states;
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return socket1;
            yield return socket2;
            yield return socket3;
            yield return socket4;
            yield return socket5;
            yield return socket6;
            yield return socket7;
            yield return socket8;

#if SOCKET_ENHANCER_TYPES_16 || SOCKET_ENHANCER_TYPES_32
            yield return socket9;
            yield return socket10;
            yield return socket11;
            yield return socket12;
            yield return socket13;
            yield return socket14;
            yield return socket15;
            yield return socket16;
#endif

#if SOCKET_ENHANCER_TYPES_32
            yield return socket17;
            yield return socket18;
            yield return socket19;
            yield return socket20;
            yield return socket21;
            yield return socket22;
            yield return socket23;
            yield return socket24;
            yield return socket25;
            yield return socket26;
            yield return socket27;
            yield return socket28;
            yield return socket29;
            yield return socket30;
            yield return socket31;
            yield return socket32;
#endif
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static class CharacterItemSocketsExtensions
    {
        public static void SetSockets(this ref CharacterItemSockets sockets, List<int> socketList)
        {
            if (socketList == null || socketList.Count != CharacterItemSockets.MAX_SOCKETS)
                return;

            sockets.socket1 = socketList[0];
            sockets.socket2 = socketList[1];
            sockets.socket3 = socketList[2];
            sockets.socket4 = socketList[3];
            sockets.socket5 = socketList[4];
            sockets.socket6 = socketList[5];
            sockets.socket7 = socketList[6];
            sockets.socket8 = socketList[7];

#if SOCKET_ENHANCER_TYPES_16 || SOCKET_ENHANCER_TYPES_32
            sockets.socket9 = socketList[8];
            sockets.socket10 = socketList[9];
            sockets.socket11 = socketList[10];
            sockets.socket12 = socketList[11];
            sockets.socket13 = socketList[12];
            sockets.socket14 = socketList[13];
            sockets.socket15 = socketList[14];
            sockets.socket16 = socketList[15];
#endif

#if SOCKET_ENHANCER_TYPES_32
            sockets.socket17 = socketList[16];
            sockets.socket18 = socketList[17];
            sockets.socket19 = socketList[18];
            sockets.socket20 = socketList[19];
            sockets.socket21 = socketList[20];
            sockets.socket22 = socketList[21];
            sockets.socket23 = socketList[22];
            sockets.socket24 = socketList[23];
            sockets.socket25 = socketList[24];
            sockets.socket26 = socketList[25];
            sockets.socket27 = socketList[26];
            sockets.socket28 = socketList[27];
            sockets.socket29 = socketList[28];
            sockets.socket30 = socketList[29];
            sockets.socket31 = socketList[30];
            sockets.socket32 = socketList[31];
#endif
        }

        public static List<int> ToList(this CharacterItemSockets sockets)
        {
            return new List<int>
            {
                sockets.socket1,
                sockets.socket2,
                sockets.socket3,
                sockets.socket4,
                sockets.socket5,
                sockets.socket6,
                sockets.socket7,
                sockets.socket8,

#if SOCKET_ENHANCER_TYPES_16 || SOCKET_ENHANCER_TYPES_32
                sockets.socket9,
                sockets.socket10,
                sockets.socket11,
                sockets.socket12,
                sockets.socket13,
                sockets.socket14,
                sockets.socket15,
                sockets.socket16,
#endif

#if SOCKET_ENHANCER_TYPES_32
                sockets.socket17,
                sockets.socket18,
                sockets.socket19,
                sockets.socket20,
                sockets.socket21,
                sockets.socket22,
                sockets.socket23,
                sockets.socket24,
                sockets.socket25,
                sockets.socket26,
                sockets.socket27,
                sockets.socket28,
                sockets.socket29,
                sockets.socket30,
                sockets.socket31,
                sockets.socket32,
#endif
            };
        }

        public static CharacterItemSockets ToCharacterItemSockets(this List<int> socketList)
        {
            CharacterItemSockets sockets = new CharacterItemSockets();
            sockets.SetSockets(socketList);
            return sockets;
        }
    }
}
