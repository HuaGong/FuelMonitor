/*==================================================================================================
'   Author          :  Arturo Salvamante
'
'   File            :  PcscProvider.cs
'
'   Compyright(C)   :  Advanced Card Systems Ltd.
'
'   Date            :  Jan 14, 2008
'
'   Revision Trail  : (Date/Author/Description)
'                     (05/28/2008/ Arturo B. Salvamante/ Added Comments & Summary)
'==================================================================================================*/


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Acs.Pcsc
{
    public class PcscProvider
    {
        public const int SCARD_S_SUCCESS = 0;
        public const int SCARD_ATR_LENGTH = 33;
        public const string winscardDLLFName = "winscard.dll";

        /// <summary>
        /// The SCARD_IO_REQUEST structure begins a protocol control information structure. Any protocol-specific information then immediately follows this structure. The entire length of the structure must be aligned with the underlying hardware architecture word size. For example, in Win32 the length of any PCI information must be a multiple of four bytes so that it aligns on a 32-bit boundary.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct SCARD_IO_REQUEST
        {
            /// <summary>
            /// Protocol in use. 
            /// </summary>
            public int dwProtocol;

            /// <summary>
            /// Length, in bytes, of the SCARD_IO_REQUEST structure plus any following PCI-specific information.
            /// </summary>
            public int cbPciLength;
        }       

        /// <summary>
        /// The SCARD_READERSTATE structure is used by functions for tracking smart cards within readers.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct SCARD_READERSTATE
        {
            /// <summary>
            /// Pointer to the name of the reader being monitored.
            /// </summary>           
            /// 
            public string szReader;

            /// <summary>
            /// Not used by the smart card subsystem. This member is used by the application.
            /// </summary>
            public IntPtr pvUserData;

            /// <summary>
            /// Current state of the reader, as seen by the application. This field can take on any of the following values, in combination, as a bit mask. 
            /// </summary>
            public int dwCurrentState;

            /// <summary>
            /// Current state of the reader, as known by the smart card resource manager. This field can take on any of the following values, in combination, as a bit mask. 
            /// </summary>
            public int dwEventState;

            /// <summary>
            /// Number of bytes in the returned ATR. 
            /// </summary>
            public int cbAtr;

            /// <summary>
            /// ATR of the inserted card, with extra alignment bytes. 
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
            public byte[] rgbAtr;
        }

        #region Memory Card Type

        public const int CT_MCU = 0x00;                   // MCU
        public const int CT_IIC_Auto = 0x01;               // IIC (Auto Detect Memory Size)
        public const int CT_IIC_1K = 0x02;                 // IIC (1K)
        public const int CT_IIC_2K = 0x03;                 // IIC (2K)
        public const int CT_IIC_4K = 0x04;                 // IIC (4K)
        public const int CT_IIC_8K = 0x05;                 // IIC (8K)
        public const int CT_IIC_16K = 0x06;                // IIC (16K)
        public const int CT_IIC_32K = 0x07;                // IIC (32K)
        public const int CT_IIC_64K = 0x08;                // IIC (64K)
        public const int CT_IIC_128K = 0x09;               // IIC (128K)
        public const int CT_IIC_256K = 0x0A;               // IIC (256K)
        public const int CT_IIC_512K = 0x0B;               // IIC (512K)
        public const int CT_IIC_1024K = 0x0C;              // IIC (1024K)
        public const int CT_AT88SC153 = 0x0D;              // AT88SC153
        public const int CT_AT88SC1608 = 0x0E;             // AT88SC1608
        public const int CT_SLE4418 = 0x0F;                // SLE4418
        public const int CT_SLE4428 = 0x10;                // SLE4428
        public const int CT_SLE4432 = 0x11;                // SLE4432
        public const int CT_SLE4442 = 0x12;                // SLE4442
        public const int CT_SLE4406 = 0x13;                // SLE4406
        public const int CT_SLE4436 = 0x14;                // SLE4436
        public const int CT_SLE5536 = 0x15;                // SLE5536
        public const int CT_MCUT0 = 0x16;                  // MCU T=0
        public const int CT_MCUT1 = 0x17;                  // MCU T=1
        public const int CT_MCU_Auto = 0x18;               // MCU Autodetect

        #endregion        

        #region Context Scope

        /// <summary>
        /// The context is a user context, and any database operations 
        /// are performed within the domain of the user.
        /// </summary>
        public const int SCARD_SCOPE_USER = 0;
        
        /// <summary>
        /// The context is that of the current terminal, and any database 
        /// operations are performed within the domain of that terminal.  
        /// (The calling application must have appropriate access permissions 
        /// for any database actions.)
        /// </summary>
        public const int SCARD_SCOPE_TERMINAL = 1;

        /// <summary>
        /// The context is the system context, and any database operations 
        /// are performed within the domain of the system.  (The calling
        /// application must have appropriate access permissions for any 
        /// database actions.)
        /// </summary>
        public const int SCARD_SCOPE_SYSTEM = 2;

        /// <summary>
        /// The application is unaware of the current state, and would like 
        /// to know. The use of this value results in an immediate return
        /// from state transition monitoring services. This is represented
        /// by all bits set to zero.
        /// </summary>
        public const int SCARD_STATE_UNAWARE = 0x00;        

        /// <summary>
        /// The application requested that this reader be ignored. No other
        /// bits will be set.
        /// </summary>
        public const int SCARD_STATE_IGNORE = 0x01;
        
        /// <summary>
        /// This implies that there is a difference between the state 
        /// believed by the application, and the state known by the Service
        /// Manager.When this bit is set, the application may assume a
        /// significant state change has occurred on this reader.
        /// </summary>
        public const int SCARD_STATE_CHANGED = 0x02;        

        /// <summary>
        /// This implies that the given reader name is not recognized by
        /// the Service Manager. If this bit is set, then SCARD_STATE_CHANGED
        /// and SCARD_STATE_IGNORE will also be set.
        /// </summary>
        public const int SCARD_STATE_UNKNOWN = 0x04;
        
        /// <summary>
        /// This implies that the actual state of this reader is not
        /// available. If this bit is set, then all the following bits are
        /// clear.
        /// </summary>
        public const int SCARD_STATE_UNAVAILABLE = 0x08;
        
        /// <summary>
        /// This implies that there is not card in the reader.  If this bit
        /// is set, all the following bits will be clear.
        /// </summary>
        public const int SCARD_STATE_EMPTY = 0x10;
        
        /// <summary>
        /// This implies that there is a card in the reader. 
        /// </summary>
        public const int SCARD_STATE_PRESENT = 0x20;
        
        /// <summary>
        /// This implies that there is a card in the reader with an ATR
        /// matching one of the target cards. If this bit is set,
        /// SCARD_STATE_PRESENT will also be set.  This bit is only returned
        /// on the SCardLocateCard() service.
        /// </summary>
        public const int SCARD_STATE_ATRMATCH = 0x40;
        
        /// <summary>
        /// This implies that the card in the reader is allocated for 
        /// exclusive use by another application. If this bit is set,
        /// SCARD_STATE_PRESENT will also be set.
        /// </summary>
        public const int SCARD_STATE_EXCLUSIVE = 0x80;
        
        /// <summary>
        /// This implies that the card in the reader is in use by one or 
        /// more other applications, but may be connected to in shared mode. 
        /// If this bit is set, SCARD_STATE_PRESENT will also be set.
        /// </summary>
        public const int SCARD_STATE_INUSE = 0x100;
        
        /// <summary>
        /// This implies that the card in the reader is unresponsive or not
        /// supported by the reader or software.
        /// </summary>
        public const int SCARD_STATE_MUTE = 0x200;
        
        /// <summary>
        /// This implies that the card in the reader has not been powered up. 
        /// </summary>
        public const int SCARD_STATE_UNPOWERED = 0x400;
        
        /// <summary>
        /// This application is not willing to share this card with other 
        /// applications.
        /// </summary>
        public const int SCARD_SHARE_EXCLUSIVE = 1;
        
        /// <summary>
        /// This application is willing to share this card with other 
        /// applications.
        /// </summary>
        public const int SCARD_SHARE_SHARED = 2;
        
        /// <summary>
        /// This application demands direct control of the reader, so it 
        /// is not available to other applications.
        /// </summary>
        public const int SCARD_SHARE_DIRECT = 3;

        #endregion

        #region Disposition

        /// <summary>
        /// Don't do anything special on close
        /// </summary>
        public const int SCARD_LEAVE_CARD = 0;

        /// <summary>
        /// Reset the card on close
        /// </summary>
        public const int SCARD_RESET_CARD = 1;

        /// <summary>
        /// Power down the card on close
        /// </summary>
        public const int SCARD_UNPOWER_CARD = 2;

        /// <summary>
        /// Eject the card on close
        /// </summary>
        public const int SCARD_EJECT_CARD = 3;

        #endregion

        #region ACS IOCTL Class
        
        public const long FILE_DEVICE_SMARTCARD = 0x310000; // Reader action IOCTLs
        public const long IOCTL_SMARTCARD_DIRECT = FILE_DEVICE_SMARTCARD + 2050 * 4;
        public const long IOCTL_SMARTCARD_SELECT_SLOT = FILE_DEVICE_SMARTCARD + 2051 * 4;
        public const long IOCTL_SMARTCARD_DRAW_LCDBMP = FILE_DEVICE_SMARTCARD + 2052 * 4;
        public const long IOCTL_SMARTCARD_DISPLAY_LCD = FILE_DEVICE_SMARTCARD + 2053 * 4;
        public const long IOCTL_SMARTCARD_CLR_LCD = FILE_DEVICE_SMARTCARD + 2054 * 4;
        public const long IOCTL_SMARTCARD_READ_KEYPAD = FILE_DEVICE_SMARTCARD + 2055 * 4;
        public const long IOCTL_SMARTCARD_READ_RTC = FILE_DEVICE_SMARTCARD + 2057 * 4;
        public const long IOCTL_SMARTCARD_SET_RTC = FILE_DEVICE_SMARTCARD + 2058 * 4;
        public const long IOCTL_SMARTCARD_SET_OPTION = FILE_DEVICE_SMARTCARD + 2059 * 4;
        public const long IOCTL_SMARTCARD_SET_LED = FILE_DEVICE_SMARTCARD + 2060 * 4;
        public const long IOCTL_SMARTCARD_LOAD_KEY = FILE_DEVICE_SMARTCARD + 2062 * 4;
        public const long IOCTL_SMARTCARD_READ_EEPROM = FILE_DEVICE_SMARTCARD + 2065 * 4;
        public const long IOCTL_SMARTCARD_WRITE_EEPROM = FILE_DEVICE_SMARTCARD + 2066 * 4;
        public const long IOCTL_SMARTCARD_GET_VERSION = FILE_DEVICE_SMARTCARD + 2067 * 4;
        public const long IOCTL_SMARTCARD_GET_READER_INFO = FILE_DEVICE_SMARTCARD + 2051 * 4;
        public const long IOCTL_SMARTCARD_SET_CARD_TYPE = FILE_DEVICE_SMARTCARD + 2060 * 4;
        public const long IOCTL_SMARTCARD_ACR128_ESCAPE_COMMAND = FILE_DEVICE_SMARTCARD + 2079 * 4;

        public const long IOCTL_SMARTCARD_ENABLE_PIN_VERIFICATION  = FILE_DEVICE_SMARTCARD + 2075 * 4;
        public const long IOCTL_SMARTCARD_ENABLE_PIN_MODIFICATION   = FILE_DEVICE_SMARTCARD + 2076 * 4;
        public const long IOCTL_SMARTCARD_DISABLE_SECURE_PIN_ENTRY  = FILE_DEVICE_SMARTCARD + 2077 * 4;
        public const long IOCTL_SMARTCARD_GET_FIRMWARE_VERSION  = FILE_DEVICE_SMARTCARD + 2078 * 4;
        public const long IOCTL_SMARTCARD_DISPLAY_LCD_MESSAGE  = FILE_DEVICE_SMARTCARD + 2079 * 4;
        public const long IOCTL_SMARTCARD_READ_KEY  = FILE_DEVICE_SMARTCARD + 2080 * 4;
        public const long CM_IOCTL_GET_FEATURE_REQUEST = FILE_DEVICE_SMARTCARD + 3400 * 4;

        
        #endregion

        #region Error Codes

        public const uint SCARD_F_INTERNAL_ERROR = 0x80100001;
        public const uint SCARD_E_CANCELLED = 0x80100002; 
        public const uint SCARD_E_INVALID_HANDLE = 0x80100003;
        public const uint SCARD_E_INVALID_PARAMETER  = 0x80100004;
        public const uint SCARD_E_INVALID_TARGET = 0x80100005;
        public const uint SCARD_E_NO_MEMORY = 0x80100006;
        public const uint SCARD_F_WAITED_TOO_LONG = 0x80100007;
        public const uint SCARD_E_INSUFFICIENT_BUFFER  = 0x80100008;
        public const uint SCARD_E_UNKNOWN_READER = 0x80100009;
        public const uint SCARD_E_TIMEOUT = 0x8010000A;
        public const uint SCARD_E_SHARING_VIOLATION  = 0x8010000B;
        public const uint SCARD_E_NO_SMARTCARD = 0x8010000C;
        public const uint SCARD_E_UNKNOWN_CARD = 0x8010000D;
        public const uint SCARD_E_CANT_DISPOSE = 0x8010000E;
        public const uint SCARD_E_PROTO_MISMATCH = 0x8010000F;
        public const uint SCARD_E_NOT_READY = 0x80100010;
        public const uint SCARD_E_INVALID_VALUE  = 0x80100011;
        public const uint SCARD_E_SYSTEM_CANCELLED = 0x80100012;
        public const uint SCARD_F_COMM_ERROR = 0x80100013;
        public const uint SCARD_F_UNKNOWN_ERROR  = 0x80100014;
        public const uint SCARD_E_INVALID_ATR  = 0x80100015;
        public const uint SCARD_E_NOT_TRANSACTED = 0x80100016;
        public const uint SCARD_E_READER_UNAVAILABLE = 0x80100017;
        public const uint SCARD_P_SHUTDOWN  = 0x80100018;
        public const uint SCARD_E_PCI_TOO_SMALL  = 0x80100019;
        public const uint SCARD_E_READER_UNSUPPORTED = 0x8010001A;
        public const uint SCARD_E_DUPLICATE_READER = 0x8010001B;
        public const uint SCARD_E_CARD_UNSUPPORTED = 0x8010001C;
        public const uint SCARD_E_NO_SERVICE = 0x8010001D;
        public const uint SCARD_E_SERVICE_STOPPED = 0x8010001E;
        public const uint SCARD_E_UNEXPECTED = 0x8010001F;
        public const uint SCARD_E_ICC_INSTALLATION = 0x80100020;
        public const uint SCARD_E_ICC_CREATEORDER = 0x80100021;
        public const uint SCARD_E_UNSUPPORTED_FEATURE  = 0x80100022;
        public const uint SCARD_E_DIR_NOT_FOUND  = 0x80100023;
        public const uint SCARD_E_FILE_NOT_FOUND = 0x80100024;
        public const uint SCARD_E_NO_DIR  = 0x80100025;
        public const uint SCARD_E_NO_FILE = 0x80100026;
        public const uint SCARD_E_NO_ACCESS = 0x80100027;
        public const uint SCARD_E_WRITE_TOO_MANY = 0x80100028;
        public const uint SCARD_E_BAD_SEEK  = 0x80100029;
        public const uint SCARD_E_INVALID_CHV  = 0x8010002A;
        public const uint SCARD_E_UNKNOWN_RES_MNG = 0x8010002B;
        public const uint SCARD_E_NO_SUCH_CERTIFICATE  = 0x8010002C;
        public const uint SCARD_E_CERTIFICATE_UNAVAILABLE = 0x8010002D;
        public const uint SCARD_E_NO_READERS_AVAILABLE = 0x8010002E;
        public const uint SCARD_E_COMM_DATA_LOST = 0x8010002F;
        public const uint SCARD_E_NO_KEY_CONTAINER = 0x80100030;
        public const uint SCARD_E_SERVER_TOO_BUSY = 0x80100031;
        public const uint SCARD_W_UNSUPPORTED_CARD = 0x80100065;
        public const uint SCARD_W_UNRESPONSIVE_CARD = 0x80100066;
        public const uint SCARD_W_UNPOWERED_CARD = 0x80100067;
        public const uint SCARD_W_RESET_CARD = 0x80100068;
        public const uint SCARD_W_REMOVED_CARD = 0x80100069;
        public const uint SCARD_W_SECURITY_VIOLATION = 0x8010006A;
        public const uint SCARD_W_WRONG_CHV = 0x8010006B;
        public const uint SCARD_W_CHV_BLOCKED = 0x8010006C;
        public const uint SCARD_W_EOF = 0x8010006D;
        public const uint SCARD_W_CANCELLED_BY_USER = 0x8010006E;
        public const uint SCARD_W_CARD_NOT_AUTHENTICATED = 0x8010006F;
        public const uint INVALID_CARD_HANDLE = 6;

        #endregion

        #region Protocol
        /// <summary>
        /// There is no active protocol.
        /// </summary>
        public const int SCARD_PROTOCOL_UNDEFINED = 0x00;

        /// <summary>
        /// T=0 is the active protocol.
        /// </summary>
        public const int SCARD_PROTOCOL_T0 = 0x01;                

        /// <summary>
        /// T=1 is the active protocol.
        /// </summary>
        public const int SCARD_PROTOCOL_T1 = 0x02;                

        /// <summary>
        /// Raw is the active protocol.
        /// </summary>
        public const int SCARD_PROTOCOL_RAW = 0x10000;

        #endregion

        #region Reader State
        
        /// <summary>
        /// This value implies the driver is unaware of the current 
        /// state of the reader.
        /// </summary>
        public const int SCARD_UNKNOWN = 0;
        
        /// <summary>
        /// This value implies there is no card in the reader.
        /// </summary>
        public const int SCARD_ABSENT = 1;
        
        /// <summary>
        /// This value implies there is a card is present in the reader, 
        /// but that it has not been moved into position for use.        
        /// </summary>
        public const int SCARD_PRESENT = 2;
        
        /// <summary>
        /// This value implies there is a card in the reader in position 
        /// for use.  The card is not powered.
        /// </summary>
        public const int SCARD_SWALLOWED = 3;
        
        /// <summary>
        /// This value implies there is power is being provided to the card, 
        /// but the Reader Driver is unaware of the mode of the card.
        /// </summary>
        public const int SCARD_POWERED = 4;
        
        /// <summary>
        /// This value implies the card has been reset and is awaiting 
        /// PTS negotiation.
        /// </summary>
        public const int SCARD_NEGOTIABLE = 5;
        
        /// <summary>
        /// This value implies the card has been reset and specific 
        /// communication protocols have been established.
        /// </summary>
        public const int SCARD_SPECIFIC = 6;        

        #endregion

        #region Prototypes

        /// <summary>
        /// The SCardEstablishContext function establishes the resource manager context (the scope) within which database operations are performed.
        /// </summary>
        /// <param name="dwScope">[in] Scope of the resource manager context. This parameter can be one of the following values.</param>
        /// <param name="pvReserved1">[in] Reserved for future use and must be NULL. This parameter will allow a suitably privileged management application to act on behalf of another user.</param>
        /// <param name="pvReserved2">[in] Reserved for future use and must be NULL. </param>
        /// <param name="phContext">[out] Handle to the established resource manager context. This handle can now be supplied to other functions attempting to do work within this context.</param>
        /// <returns></returns>       
        [DllImport(winscardDLLFName)]
        public static extern int SCardEstablishContext(int dwScope, int pvReserved1, int pvReserved2, ref IntPtr phContext);

        /// <summary>
        /// The SCardReleaseContext function closes an established resource manager context, freeing any resources allocated under that context, including SCARDHANDLE objects and memory allocated using the SCARD_AUTOALLOCATE length designator.
        /// </summary>
        /// <param name="phContext">[in] Handle that identifies the resource manager context. The resource manager context is set by a previous call to SCardEstablishContext.</param>
        /// <returns></returns>
        [DllImport(winscardDLLFName)]
        public static extern int SCardReleaseContext(IntPtr phContext);


        /// <summary>
        /// The SCardConnect function establishes a connection (using a specific resource manager context) between the calling application and a smart card contained by a specific reader. If no card exists in the specified reader, an error is returned.
        /// </summary>
        /// <param name="hContext">[in] A handle that identifies the resource manager context. The resource manager context is set by a previous call to SCardEstablishContext.</param>
        /// <param name="szReaderName">[in] The name of the reader that contains the target card. </param>
        /// <param name="dwShareMode">[in] A flag that indicates whether other applications may form connections to the card.</param>
        /// <param name="dwPrefProtocol">[in] A bit mask of acceptable protocols for the connection. Possible values may be combined with the OR operation.</param>
        /// <param name="phCard">[out] A handle that identifies the connection to the smart card in the designated reader. </param>
        /// <param name="activeProtocol">[out] A flag that indicates the established active protocol.</param>
        /// <returns></returns>
        [DllImport(winscardDLLFName)]
        public static extern int SCardConnect(IntPtr hContext, string szReaderName, int dwShareMode, int dwPrefProtocol, ref IntPtr phCard, ref int activeProtocol);

        /// <summary>
        /// The SCardBeginTransaction function starts a transaction, waiting for the completion of all other transactions before it begins.
        /// When the transaction starts, all other applications are blocked from accessing the smart card while the transaction is in progress.
        /// </summary>
        /// <param name="hCard">[in] Reference value obtained from a previous call to SCardConnect.</param>
        /// <returns>This function returns different values depending on whether it succeeds or fails.</returns>
        [DllImport(winscardDLLFName)]
        public static extern int SCardBeginTransaction(IntPtr hCard);

        /// <summary>
        /// The SCardDisconnect function terminates a connection previously opened between the calling application and a smart card in the target reader.
        /// </summary>
        /// <param name="hCard">[in] Reference value obtained from a previous call to SCardConnect. </param>
        /// <param name="Disposition">[in] Action to take on the card in the connected reader on close. </param>
        /// <returns>This function returns different values depending on whether it succeeds or fails.</returns>
        [DllImport(winscardDLLFName)]
        public static extern int SCardDisconnect(IntPtr hCard, int Disposition);

        /// <summary>
        /// The SCardListReaderGroups function provides the list of reader groups that have previously been introduced to the system.
        /// </summary>
        /// <param name="hContext">[in] Handle that identifies the resource manager context for the query. The resource manager context can be set by a previous call to SCardEstablishContext. This parameter cannot be NULL.</param>
        /// <param name="mzGroups">[out] Multi-string that lists the reader groups defined to the system and available to the current user on the current terminal. If this value is NULL, SCardListReaderGroups ignores the buffer length supplied in pcchGroups, writes the length of the buffer that would have been returned if this parameter had not been NULL to pcchGroups, and returns a success code.</param>
        /// <param name="pcchGroups">[in, out] Length of the mszGroups buffer in characters, and receives the actual length of the multi-string structure, including all trailing null characters. If the buffer length is specified as SCARD_AUTOALLOCATE, then mszGroups is converted to a pointer to a byte pointer, and receives the address of a block of memory containing the multi-string structure. This block of memory must be deallocated with SCardFreeMemory. </param>
        /// <returns>This function returns different values depending on whether it succeeds or fails.</returns>
        [DllImport(winscardDLLFName)]
        public static extern int SCardListReaderGroups(IntPtr hContext, ref string mzGroups, ref int pcchGroups);

        /// <summary>
        /// The SCardListReaders function provides the list of readers within a set of named reader groups, eliminating duplicates.
        /// The caller supplies a list of reader groups, and receives the list of readers within the named groups. Unrecognized group names are ignored.
        /// </summary>
        /// <param name="hContext">[in] Handle that identifies the resource manager context for the query. The resource manager context can be set by a previous call to SCardEstablishContext. This parameter cannot be NULL.</param>
        /// <param name="Groups">[in] Names of the reader groups defined to the system, as a multi-string. Use a NULL value to list all readers in the system (that is, the SCard$AllReaders group). </param>
        /// <param name="Readers">[out] Multi-string that lists the card readers within the supplied reader groups. If this value is NULL, SCardListReaders ignores the buffer length supplied in pcchReaders, writes the length of the buffer that would have been returned if this parameter had not been NULL to pcchReaders, and returns a success code.</param>
        /// <param name="pcchReaders">[in, out] Length of the mszReaders buffer in characters. This parameter receives the actual length of the multi-string structure, including all trailing null characters. If the buffer length is specified as SCARD_AUTOALLOCATE, then mszReaders is converted to a pointer to a byte pointer, and receives the address of a block of memory containing the multi-string structure. This block of memory must be deallocated with SCardFreeMemory.</param>
        /// <returns>This function returns different values depending on whether it succeeds or fails.</returns>
        [DllImport(winscardDLLFName, EntryPoint = "SCardListReadersA", CharSet = CharSet.Ansi)]
        public static extern int SCardListReaders(
            IntPtr hContext,
            byte[] Groups,
            byte[] Readers,
            ref int pcchReaders
            );

        /// <summary>
        /// The SCardStatus function provides the current status of a smart card in a reader. You can call it any time after a successful call to SCardConnect and before a successful call to SCardDisconnect. It does not affect the state of the reader or reader driver.
        /// </summary>
        /// <param name="hCard">[in] Reference value returned from SCardConnect. </param>
        /// <param name="szReaderName">[out] List of friendly names (multiple string) by which the currently connected reader is known. </param>
        /// <param name="pcchReaderLen">[in, out] On input, supplies the length of the szReaderName buffer. 
        /// On output, receives the actual length (in characters) of the reader name list, including the trailing NULL character. If this buffer length is specified as SCARD_AUTOALLOCATE, then szReaderName is converted to a pointer to a byte pointer, and it receives the address of a block of memory that contains the multiple-string structure.</param>
        /// <param name="State">[out] Current state of the smart card in the reader. Upon success, it receives one of the following state indicators.</param>
        /// <param name="Protocol">[out] Current protocol, if any. The returned value is meaningful only if the returned value of pdwState is SCARD_SPECIFICMODE.</param>
        /// <param name="ATR">[out] Pointer to a 32-byte buffer that receives the ATR string from the currently inserted card, if available.</param>
        /// <param name="ATRLen">[in, out] On input, supplies the length of the pbAtr buffer. On output, receives the number of bytes in the ATR string (32 bytes maximum). If this buffer length is specified as SCARD_AUTOALLOCATE, then pbAtr is converted to a pointer to a byte pointer, and it receives the address of a block of memory that contains the multiple-string structure.</param>
        /// <returns>If the function successfully provides the current status of a smart card in a reader, the return value is SCARD_S_SUCCESS.
        /// If the function fails, it returns an error code. For more information, see Smart Card Return Values.</returns>
        [DllImport(winscardDLLFName)]
        public static extern int SCardStatus(IntPtr hCard, string szReaderName, ref int pcchReaderLen, ref int State, ref int Protocol, byte[] ATR, ref int ATRLen);


        /// <summary>
        /// The SCardGetStatusChange function blocks execution until the current availability of the cards in a specific set of readers changes.
        /// </summary>
        /// <param name="hContext">A handle that identifies the resource manager context. The resource manager context is set by a previous call to the SCardEstablishContext function.</param>
        /// <param name="TimeOut">The maximum amount of time, in milliseconds, to wait for an action. A value of zero causes the function to return immediately. A value of INFINITE causes this function never to time out.</param>
        /// <param name="ReaderState">
        /// An array of SCARD_READERSTATE structures that specify the readers to watch, and that receives the result.
        /// To be notified of the arrival of a new smart card reader, set the szReader member of a SCARD_READERSTATE structure to "\\\\?PnP?\\Notification", and set all of the other members of that structure to zero.
        /// Important  Each member of each structure in this array must be initialized to zero and then set to specific values as necessary. If this is not done, the function will fail in situations that involve remote card readers.
        /// </param>
        /// <param name="ReaderCount">The number of elements in the rgReaderStates array.</param>
        /// <returns></returns>
        [DllImport("winscard.dll", EntryPoint = "SCardGetStatusChangeA", CharSet = CharSet.Ansi)]
        public static extern int SCardGetStatusChange(IntPtr hContext, int TimeOut, ref SCARD_READERSTATE ReaderState, int ReaderCount);


        /// <summary>
        /// The SCardEndTransaction function completes a previously declared transaction, allowing other applications to resume interactions with the card.
        /// </summary>
        /// <param name="hCard">[in] Reference value obtained from a previous call to SCardConnect. This value would also have been used in an earlier call to SCardBeginTransaction.</param>
        /// <param name="Disposition">[in] Action to take on the card in the connected reader on close. </param>
        /// <returns>This function returns different values depending on whether it succeeds or fails.</returns>
        [DllImport(winscardDLLFName)]
        public static extern int SCardEndTransaction(IntPtr hCard, int Disposition);

        [DllImport(winscardDLLFName)]
        public static extern int SCardState(IntPtr hCard, ref uint State, ref uint Protocol, ref byte ATR, ref uint ATRLen);

        /// <summary>
        /// The SCardTransmit function sends a service request to the smart card and expects to receive data back from the card.
        /// </summary>
        /// <param name="hCard">[in] A reference value returned from the SCardConnect function.</param>
        /// <param name="pioSendRequest">[in] A pointer to the protocol header structure for the instruction. This buffer is in the format of an SCARD_IO_REQUEST structure, followed by the specific protocol control information (PCI).
        /// For the T=0, T=1, and Raw protocols, the PCI structure is constant. The smart card subsystem supplies a global T=0, T=1, or Raw PCI structure, which you can reference by using the symbols SCARD_PCI_T0, SCARD_PCI_T1, and SCARD_PCI_RAW respectively.</param>
        /// <param name="SendBuff">[in] A pointer to the actual data to be written to the card. </param>
        /// <param name="SendBuffLen">[in] The length, in bytes, of the pbSendBuffer parameter. </param>
        /// <param name="pioRecvRequest">[in, out] Pointer to the protocol header structure for the instruction, followed by a buffer in which to receive any returned protocol control information (PCI) specific to the protocol in use. This parameter can be NULL if no PCI is returned. </param>
        /// <param name="RecvBuff">[out] Pointer to any data returned from the card. </param>
        /// <param name="RecvBuffLen">[in, out] Supplies the length, in bytes, of the pbRecvBuffer parameter and receives the actual number of bytes received from the smart card. This value cannot be SCARD_AUTOALLOCATE because SCardTransmit does not support SCARD_AUTOALLOCATE.</param>
        /// <returns>If the function successfully sends a service request to the smart card, the return value is SCARD_S_SUCCESS.
        /// If the function fails, it returns an error code. For more information, see Smart Card Return Values.</returns>
        [DllImport(winscardDLLFName, SetLastError=true)]
        public static extern int SCardTransmit(IntPtr hCard, ref SCARD_IO_REQUEST pioSendRequest, byte[] SendBuff, int SendBuffLen, ref SCARD_IO_REQUEST pioRecvRequest, byte[] RecvBuff, ref int RecvBuffLen);

        /// <summary>
        /// The SCardControl function gives you direct control of the reader. You can call it any time after a successful call to SCardConnect and before a successful call to SCardDisconnect. The effect on the state of the reader depends on the control code.
        /// </summary>
        /// <param name="hCard">[in] Reference value returned from SCardConnect. </param>
        /// <param name="dwControlCode">[in] Control code for the operation. This value identifies the specific operation to be performed.</param>
        /// <param name="SendBuff">[in] Pointer to a buffer that contains the data required to perform the operation. This parameter can be NULL if the dwControlCode parameter specifies an operation that does not require input data. </param>
        /// <param name="SendBuffLen">[in] Size, in bytes, of the buffer pointed to by lpInBuffer. </param>
        /// <param name="RecvBuff">[out] Pointer to a buffer that receives the operation's output data. This parameter can be NULL if the dwControlCode parameter specifies an operation that does not produce output data. </param>
        /// <param name="RecvBuffLen">[in] Size, in bytes, of the buffer pointed to by lpOutBuffer. </param>
        /// <param name="pcbBytesReturned">[out] Pointer to a DWORD that receives the size, in bytes, of the data stored into the buffer pointed to by lpOutBuffer. </param>
        /// <returns>This function returns different values depending on whether it succeeds or fails.</returns>
        [DllImport(winscardDLLFName)]
        public static extern int SCardControl(IntPtr hCard, uint dwControlCode, byte[] SendBuff, int SendBuffLen, [In, Out] byte[] RecvBuff, int RecvBuffLen, [In, Out]  ref int pcbBytesReturned);


        [DllImport(winscardDLLFName)]
        public static extern int SCardReconnect(IntPtr hContext, int dwShareMode, int dwPrefProtocol, int dwInitialization, ref int activeProtocol);

        #endregion

        #region Miscellaneous

        /// <summary>
        /// Returns the specific error message
        /// </summary>
        /// <param name="errCode">The error code</param>
        /// <returns></returns>
        public static string GetScardErrMsg(long errCode)
        {
            switch ((uint)errCode)
            {
                case SCARD_F_INTERNAL_ERROR:
                    return "An internal consistency check failed";

                case SCARD_E_CANCELLED:
                    return "The action was cancelled by a SCardCancel request";

                case SCARD_E_INVALID_HANDLE:
                    return "The supplied handle was invalid";

                case SCARD_E_INVALID_PARAMETER:
                    return "One or more of the supplied parameters could not be properly interpreted";

                case SCARD_E_INVALID_TARGET:
                    return "Registry startup information is missing or invalid";

                case SCARD_E_NO_MEMORY:
                    return "Not enough memory available to complete this command";

                case SCARD_F_WAITED_TOO_LONG:
                    return "An internal consistency timer has expired";

                case SCARD_E_INSUFFICIENT_BUFFER:
                    return "The data buffer to receive returned data is too small for the returned data";

                case SCARD_E_UNKNOWN_READER:
                    return "The specified reader name is not recognized";

                case SCARD_E_TIMEOUT:
                    return "The user-specified timeout value has expired";

                case SCARD_E_SHARING_VIOLATION:
                    return "The smart card cannot be accessed because of other connections outstanding";

                case SCARD_E_NO_SMARTCARD:
                    return "The operation requires a smart card, but no smart card is currently in the device";

                case SCARD_E_UNKNOWN_CARD:
                    return "The specified smart card name is not recognized";

                case SCARD_E_CANT_DISPOSE:
                    return "The system could not dispose of the media in the requested manner";

                case SCARD_E_PROTO_MISMATCH:
                    return "The requested protocols are incompatible with the protocol currently in use with the smart card";

                case SCARD_E_NOT_READY:
                    return "The reader or smart card is not ready to accept commands";

                case SCARD_E_INVALID_VALUE:
                    return "One or more of the supplied parameters values could not be properly interpreted";

                case SCARD_E_SYSTEM_CANCELLED:
                    return "The action was cancelled by the system, presumably to log off or shut down";

                case SCARD_F_COMM_ERROR:
                    return "An internal communications error has been detected";

                case SCARD_F_UNKNOWN_ERROR:
                    return "An internal error has been detected, but the source is unknown";

                case SCARD_E_INVALID_ATR:
                    return "An ATR obtained from the registry is not a valid ATR string";

                case SCARD_E_NOT_TRANSACTED:
                    return "An attempt was made to end a non-existent transaction";

                case SCARD_E_READER_UNAVAILABLE:
                    return "The specified reader is not currently available for use";

                case SCARD_P_SHUTDOWN:
                    return "The operation has been aborted to allow the server application to exit";

                case SCARD_E_PCI_TOO_SMALL:
                    return "The PCI Receive buffer was too small";

                case SCARD_E_READER_UNSUPPORTED:
                    return "The reader driver does not meet minimal requirements for support";

                case SCARD_E_DUPLICATE_READER:
                    return "The reader driver did not produce a unique reader name";

                case SCARD_E_CARD_UNSUPPORTED:
                    return "The smart card does not meet minimal requirements for support";

                case SCARD_E_NO_SERVICE:
                    return "The Smart Card Resource Manager is not running";

                case SCARD_E_SERVICE_STOPPED:
                    return "The Smart Card Resource Manager has shut down";

                case SCARD_E_UNEXPECTED:
                    return "An unexpected card error has occurred";

                case SCARD_E_ICC_INSTALLATION:
                    return "No primary provider can be found for the smart card";

                case SCARD_E_ICC_CREATEORDER:
                    return "The requested order of object creation is not supported";

                case SCARD_E_UNSUPPORTED_FEATURE:
                    return "This smart card does not support the requested feature";

                case SCARD_E_DIR_NOT_FOUND:
                    return "The identified directory does not exist in the smart card";

                case SCARD_E_FILE_NOT_FOUND:
                    return "The identified file does not exist in the smart card";

                case SCARD_E_NO_DIR:
                    return "The supplied path does not represent a smart card directory";

                case SCARD_E_NO_FILE:
                    return "The supplied path does not represent a smart card file";

                case SCARD_E_NO_ACCESS:
                    return "Access is denied to this file";

                case SCARD_E_WRITE_TOO_MANY:
                    return "The smart card does not have enough memory to store the information";

                case SCARD_E_BAD_SEEK:
                    return "There was an error trying to set the smart card file object pointer";

                case SCARD_E_INVALID_CHV:
                    return "The supplied PIN is incorrect";

                case SCARD_E_UNKNOWN_RES_MNG:
                    return "An unrecognized error code was                     returned from a layered component";

                case SCARD_E_NO_SUCH_CERTIFICATE:
                    return "The requested certificate does not exist";

                case SCARD_E_CERTIFICATE_UNAVAILABLE:
                    return "The requested certificate could not be obtained";

                case SCARD_E_NO_READERS_AVAILABLE:
                    return "Cannot find a smart card reader";

                case SCARD_E_COMM_DATA_LOST:
                    return "A communications error with the smart card has been detected. Retry the operation";

                case SCARD_E_NO_KEY_CONTAINER:
                    return "The requested key container does not exist on the smart card";

                case SCARD_E_SERVER_TOO_BUSY:
                    return "The Smart Card Resource Manager is too busy to complete this operation";

                case SCARD_W_UNSUPPORTED_CARD:
                    return "The reader cannot communicate with the card, due to ATR string configuration conflicts";

                case SCARD_W_UNRESPONSIVE_CARD:
                    return "The smart card is not responding to a reset";

                case SCARD_W_UNPOWERED_CARD:
                    return "Power has been removed from the smart card, so that further communication is not possible";

                case SCARD_W_RESET_CARD:
                    return "The smart card has been reset, so any shared state information is invalid";

                case SCARD_W_REMOVED_CARD:
                    return "The smart card has been removed, so further communication is not possible";

                case SCARD_W_SECURITY_VIOLATION:
                    return "Access was denied because of a security violation";

                case SCARD_W_WRONG_CHV:
                    return "The card cannot be accessed because the wrong PIN was presented";

                case SCARD_W_CHV_BLOCKED:
                    return "The card cannot be accessed because the maximum number of PIN entry attempts has been reached";

                case SCARD_W_EOF:
                    return "The end of the smart card file has been reached";

                case SCARD_W_CANCELLED_BY_USER:
                    return "The action was cancelled by the user";

                case SCARD_W_CARD_NOT_AUTHENTICATED:
                    return "No PIN was presented to the smart card";

                case INVALID_CARD_HANDLE:
                    return "The handle is invalid";

                default: return "Unknown Error";
            }
        }


        /// <summary>
        /// Returns the type of card
        /// </summary>
        /// <param name="sel_Res"></param>
        /// <returns></returns>
        public static string GetTagType(byte sel_Res)
        {
            switch (sel_Res)
            {
                case 0x00:
                    return ("MIFARE Ultralight");
                case 0x08:
                    return ("MIFARE 1K");
                case 0x09:
                    return ("MIFARE MINI");
                case 0x18:
                    return ("MIFARE 4K");
                case 0x20:
                    return ("MIFARE DESFIRE ");
                case 0x28:
                    return ("JCOP30");
                case 0x98:
                    return ("Gemplus MPCOS");
                default:
                    return ("Unknown Card");
                    
            }
        }
        

        #endregion





    }
}
