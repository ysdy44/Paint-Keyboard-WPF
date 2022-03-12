using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Paint_Keyboard.Elements
{

    #region Input

    // Declare the Input struct
    [StructLayout(LayoutKind.Sequential)]
    internal struct Input
    {
        public InputType Type;
        public InputUnion Union;
        public static int Size => Marshal.SizeOf(typeof(Input));
    }

    [Flags]
    internal enum InputType : int
    {
        Mouse = 0,
        Keyboard = 1,
        Hardware = 2
    }

    // Declare the InputUnion struct
    [StructLayout(LayoutKind.Explicit)]
    public struct InputUnion
    {
        [FieldOffset(0)]
        internal MouseInput M;
        [FieldOffset(0)]
        internal KeyboardInput K;
        [FieldOffset(0)]
        internal HardwareInput H;
    }

    #endregion


    #region Mouse

    [StructLayout(LayoutKind.Sequential)]
    public struct MouseInput
    {
        internal int X;
        internal int Y;
        internal MouseEventDataXButtons MouseData;
        internal MouseEventF Flags;
        internal uint Time;
        internal UIntPtr ExtraInfo;
    }

    [Flags]
    public enum MouseEventDataXButtons : uint
    {
        Nothing = 0x00000000,
        XButton1 = 0x00000001,
        XButton2 = 0x00000002
    }

    [Flags]
    public enum MouseEventF : uint
    {
        Absolute = 0X8000,
        HWheel = 0X01000,
        Move = 0X0001,
        Move_NoCoalesce = 0X2000,
        Leftdown = 0X0002,
        Leftup = 0X0004,
        RightDown = 0X0008,
        RightUp = 0X0010,
        MiddleDown = 0X0020,
        MiddleUp = 0X0040,
        VirtualDesk = 0X4000,
        Wheel = 0X0800,
        XDown = 0X0080,
        XUp = 0X0100
    }

    #endregion


    #region Keyboard

    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardInput
    {
        internal VirtualKeyShort Vk;
        internal ScanCodeShort Scan;
        internal KeyEvent Flags;
        internal int Time;
        internal UIntPtr ExtraInfo;
    }

    [Flags]
    public enum KeyEvent : uint
    {
        KeyDown = 0b0000, // 0
        ExtendedKey = 0b0001, // 1
        KeyUp = 0b0010, // 2
        Unicode = 0b0100, // 4
        ScanCode = 0b1000, // 8
    }

    public enum VirtualKeyShort : short
    {
        //Left mouse Button
        LButton = 0x01,
        //Right mouse Button
        RButton = 0x02,
        //Control-break processing
        Cancel = 0x03,
        //Middle mouse Button (three-Button mouse)
        MButton = 0x04,
        //Windows 2000/XP: X1 mouse Button
        XButton1 = 0x05,
        //Windows 2000/XP: X2 mouse Button
        XButton2 = 0x06,
        //BackSpace key
        Back = 0x08,
        //Tab key
        Tab = 0x09,
        //Clear key
        Clear = 0x0C,
        //Enter key
        Return = 0x0D,
        //Shift key
        Shift = 0x10,
        //CTRL key
        Control = 0x11,
        //ALT key
        Menu = 0x12,
        //Pause key
        Pause = 0x13,
        //Caps Lock key
        Capital = 0x14,
        //Input Method Editor (IME) Kana mode
        Kana = 0x15,
        //IME Hangul mode
        Hangul = 0x15,
        //IME Junja mode
        Junja = 0x17,
        //IME final mode
        Final = 0x18,
        //IME Hanja mode
        Hanja = 0x19,
        //IME Kanji mode
        Kanji = 0x19,
        //ESC key
        Escape = 0x1B,
        //IME convert
        Convert = 0x1C,
        //IME nonconvert
        NonConvert = 0x1D,
        //IME accept
        Accept = 0x1E,
        //IME mode change request
        ModeChange = 0x1F,
        //SpaceBar
        Space = 0x20,
        //Page Up key
        Prior = 0x21,
        //Page Down key
        Next = 0x22,
        //End key
        End = 0x23,
        //Home key
        Home = 0x24,
        //Left ARROW key
        Left = 0x25,
        //Up ARROW key
        Up = 0x26,
        //Right ARROW key
        Right = 0x27,
        //Down ARROW key
        Down = 0x28,
        //Select key
        Select = 0x29,
        //	Print key
        Print = 0x2A,
        //	Execute key
        Execute = 0x2B,
        //	Print Screen key
        SnapShot = 0x2C,
        //	Ins key
        Insert = 0x2D,
        //	Del key
        Delete = 0x2E,
        //	Help key
        Help = 0x2F,
        //	0 key
        N0 = 0x30,
        //	1 key
        N1 = 0x31,
        //	2 key
        N2 = 0x32,
        //	3 key
        N3 = 0x33,
        //	4 key
        N4 = 0x34,
        //	5 key
        N5 = 0x35,
        //	6 key
        N6 = 0x36,
        //	7 key
        N7 = 0x37,
        //	8 key
        N8 = 0x38,
        //	9 key
        N9 = 0x39,
        //	A key
        A = 0x41,
        //	B key
        B = 0x42,
        //	C key
        C = 0x43,
        //	D key
        D = 0x44,
        //	E key
        E = 0x45,
        //	F key
        F = 0x46,
        //	G key
        G = 0x47,
        //	H key
        H = 0x48,
        //	I key
        I = 0x49,
        //	J key
        J = 0x4A,
        //	K key
        K = 0x4B,
        //	L key
        L = 0x4C,
        //	M key
        M = 0x4D,
        //	N key
        N = 0x4E,
        //	O key
        O = 0x4F,
        //	P key
        P = 0x50,
        //	Q key
        Q = 0x51,
        //	R key
        R = 0x52,
        //	S key
        S = 0x53,
        //	T key
        T = 0x54,
        //	U key
        U = 0x55,
        //	V key
        V = 0x56,
        //	W key
        W = 0x57,
        //	X key
        X = 0x58,
        //	Y key
        Y = 0x59,
        //	Z key
        Z = 0x5A,
        //	Left Windows key (Microsoft Natural keyboard)
        LWin = 0x5B,
        //	Right Windows key (Natural keyboard)
        RWin = 0x5C,
        //	Applications key (Natural keyboard)
        Apps = 0x5D,
        //	Computer Sleep key
        Sleep = 0x5F,
        //	Numeric keypad 0 key
        Numpad0 = 0x60,
        //	Numeric keypad 1 key
        Numpad1 = 0x61,
        //	Numeric keypad 2 key
        Numpad2 = 0x62,
        //	Numeric keypad 3 key
        Numpad3 = 0x63,
        //	Numeric keypad 4 key
        Numpad4 = 0x64,
        //	Numeric keypad 5 key
        Numpad5 = 0x65,
        //	Numeric keypad 6 key
        Numpad6 = 0x66,
        //	Numeric keypad 7 key
        Numpad7 = 0x67,
        //	Numeric keypad 8 key
        Numpad8 = 0x68,
        //	Numeric keypad 9 key
        Numpad9 = 0x69,
        //	Multiply key
        Multiply = 0x6A,
        //	Add key
        Add = 0x6B,
        //	Separator key
        Separator = 0x6C,
        //	Subtract key
        Subtract = 0x6D,
        //	Decimal key
        Decimal = 0x6E,
        //	Divide key
        Divide = 0x6F,
        //	F1 key
        F1 = 0x70,
        //	F2 key
        F2 = 0x71,
        //	F3 key
        F3 = 0x72,
        //	F4 key
        F4 = 0x73,
        //	F5 key
        F5 = 0x74,
        //	F6 key
        F6 = 0x75,
        //	F7 key
        F7 = 0x76,
        //	F8 key
        F8 = 0x77,
        //	F9 key
        F9 = 0x78,
        //	F10 key
        F10 = 0x79,
        //	F11 key
        F11 = 0x7A,
        //	F12 key
        F12 = 0x7B,
        //	F13 key
        F13 = 0x7C,
        //	F14 key
        F14 = 0x7D,
        //	F15 key
        F15 = 0x7E,
        //	F16 key
        F16 = 0x7F,
        //	F17 key
        F17 = 0x80,
        //	F18 key
        F18 = 0x81,
        //	F19 key
        F19 = 0x82,
        //	F20 key
        F20 = 0x83,
        //	F21 key
        F21 = 0x84,
        //	F22 key, (PPC only) Key used to lock device.
        F22 = 0x85,
        //	F23 key
        F23 = 0x86,
        //	F24 key
        F24 = 0x87,
        //	NUM Lock key
        NumLock = 0x90,
        //	Scroll Lock key
        Scroll = 0x91,
        //	Left Shift key
        LShift = 0xA0,
        //	Right Shift key
        RShift = 0xA1,
        //	Left Control key
        LControl = 0xA2,
        //	Right Control key
        RControl = 0xA3,
        //	Left Menu key
        LMenu = 0xA4,
        //	Right Menu key
        RMenu = 0xA5,
        //	Windows 2000/XP: Browser Back key
        Browser_Back = 0xA6,
        //	Windows 2000/XP: Browser Forward key
        Browser_Forward = 0xA7,
        //	Windows 2000/XP: Browser Refresh key
        Browser_Refresh = 0xA8,
        //	Windows 2000/XP: Browser Stop key
        Browser_Stop = 0xA9,
        //	Windows 2000/XP: Browser Search key
        Browser_Search = 0xAA,
        //	Windows 2000/XP: Browser Favorites key
        Browser_Favorites = 0xAB,
        //	Windows 2000/XP: Browser Start and Home key
        Browser_Home = 0xAC,
        //	Windows 2000/XP: Volume Mute key
        Volume_Mute = 0xAD,
        //	Windows 2000/XP: Volume Down key
        Volume_Down = 0xAE,
        //	Windows 2000/XP: Volume Up key
        Volume_Up = 0xAF,
        //	Windows 2000/XP: Next Track key
        Media_Next_Track = 0xB0,
        //	Windows 2000/XP: Previous Track key
        Media_Prev_Track = 0xB1,
        //	Windows 2000/XP: Stop Media key
        Media_Stop = 0xB2,
        //	Windows 2000/XP: Play/Pause Media key
        Media_Play_Pause = 0xB3,
        //	Windows 2000/XP: Start Mail key
        Launch_MAIL = 0xB4,
        //	Windows 2000/XP: Select Media key
        Launch_Media_Select = 0xB5,
        //	Windows 2000/XP: Start Application 1 key
        Launch_App1 = 0xB6,
        //	Windows 2000/XP: Start Application 2 key
        Launch_App2 = 0xB7,
        //	Used for miscellaneous characters; it can vary by keyboard.
        Oem_1 = 0xBA,
        //	Windows 2000/XP: For any country/region, the '+' key
        Oem_Plus = 0xBB,
        //	Windows 2000/XP: For any country/region, the ',' key
        Oem_Comma = 0xBC,
        //	Windows 2000/XP: For any country/region, the '-' key
        Oem_Minus = 0xBD,
        //	Windows 2000/XP: For any country/region, the '.' key
        Oem_Period = 0xBE,
        //	Used for miscellaneous characters; it can vary by keyboard.
        Oem_2 = 0xBF,
        //	Used for miscellaneous characters; it can vary by keyboard.
        Oem_3 = 0xC0,
        //	Used for miscellaneous characters; it can vary by keyboard.
        Oem_4 = 0xDB,
        //	Used for miscellaneous characters; it can vary by keyboard.
        Oem_5 = 0xDC,
        //	Used for miscellaneous characters; it can vary by keyboard.
        Oem_6 = 0xDD,
        //	Used for miscellaneous characters; it can vary by keyboard.
        Oem_7 = 0xDE,
        //	Used for miscellaneous characters; it can vary by keyboard.
        Oem_8 = 0xDF,
        //	Windows 2000/XP: Either the angle bracket key or the backslash key on the RT 102-key keyboard
        Oem_102 = 0xE2,
        //	Windows 95/98/Me, Windows NT 4.0, Windows 2000/XP: IME PROCESS key
        ProcessKey = 0xE5,
        //	Windows 2000/XP: Used to pass Unicode characters as if they were keystrokes.
        // The VK_Packet key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information,
        //	see Remark in KeyBDInput, SendInput, WM_KeyDown, and WM_KeyUp
        Packet = 0xE7,
        //	Attn key
        Attn = 0xF6,
        //	CrSel key
        Crsel = 0xF7,
        //	ExSel key
        Exsel = 0xF8,
        //	Erase EOF key
        Ereof = 0xF9,
        //	Play key
        Play = 0xFA,
        //	Zoom key
        Zoom = 0xFB,
        //	Reserved
        NoName = 0xFC,
        //	Pa1 key
        Pa1 = 0xFD,
        //	Clear key
        Oem_Clear = 0xFE
    }

    /// <summary>
    /// <see cref="System.Windows.Input.Key"/>
    /// </summary>
    public enum ScanCodeShort : short
    {
        //LButton = 0,
        //RButton = 0,
        //MButton = 0,
        //XButton1 = 0,
        //XButton2 = 0,

        //Pause = 0,
        //Kana = 0,
        //Hangul = 0,
        //Junja = 0,
        //Final = 0,
        //Hanja = 0,
        //Kanji = 0,
        //Convert = 0,
        //NonConvert = 0,
        //Accept = 0,
        //ModeChange = 0,

        //Select = 0,
        //Execute = 0,
        //Separator = 0,
        //ProcessKey = 0,
        //Packet = 0,
        //Attn = 0,
        //Crsel = 0,
        //Exsel = 0,
        //Play = 0,
        //Noname = 0,
        //Pa1 = 0,
        //OemClear = 0,
        ////Oem8 = 0,

        Escape = 1, // Esc

        D1 = 2,
        D2 = 3,
        D3 = 4,
        D4 = 5,
        D5 = 6,
        D6 = 7,
        D7 = 8,
        D8 = 9,
        D9 = 10,
        D0 = 11,

        OemMinus = 12, // -
        OemPlus = 13,// = +
        Back = 14, // Backspace
        Tab = 15,
        Q = 16,
        //MediaPreviousTrack = 16,
        W = 17,
        E = 18,
        R = 19,
        T = 20,
        Y = 21,
        U = 22,
        I = 23,
        O = 24,
        P = 25,
        //MediaNextTrack = 25,
        OemOpenBrackets = 26, // [
        //Oem4 = 26,
        OemCloseBrackets = 27, // ]
        //Oem6 = 27,
        Return = 28, // Enter
        Ctrl = 29, // Control
        //LeftCtrl = 29,
        //RightCtrl = 29,

        A = 30,
        S = 31,
        D = 32,
        //VolumeMute = 32,
        F = 33,
        //LaunchApplication2 = 33,
        G = 34,
        //MediaPlayPause = 34,
        H = 35,
        J = 36,
        //MediaStop = 36,
        K = 37,
        L = 38,
        OemSemicolon = 39, // ; 
        //Oem1 = 39,

        OemQuotes = 40, // ' 
        //Oem7 = 40,
        OemTilde = 41, // ` 
        //Oem3 = 41,
        //LeftShift = 42,
        Shift = 42,
        //Oem5 = 43,
        OemBackslash = 43, // \
        Z = 44,
        X = 45,
        C = 46,
        //VolumeDown = 46,
        V = 47,
        B = 48,
        //VolumeUp = 48,
        N = 49,

        M = 50,
        //BrowserHome = 50,
        OemComma = 51, // ，
        OemPeriod = 52, // .
        //Divide = 53,
        OemQuestion = 53, // ? /
        //Oem2 = 53,
        RightShift = 54,
        Multiply = 55,
        Alt = 56, // Menu
        //LeftAlt = 56,
        //RightAlt = 56,
        Space = 57, // Spacebar
        Capital = 58,  // Caps Lock (Caps)
        //CapsLock = 58, 

        F1 = 59,
        F2 = 60,
        F3 = 61,
        F4 = 62,
        F5 = 63,
        F6 = 64,
        F7 = 65,
        F8 = 66,
        F9 = 67,
        F10 = 68,

        NumLock = 69, // Num Lock
        Scroll = 70, // Scroll Lock
        //Cancel = 70,
        Home = 71,
        //Numpad7 = 71,
        Up = 72,
        //Numpad8 = 72,
        Prior = 73, // Page Up (Previous)
        //PageUp = 73,
        //Numpad9 = 73,
        Subtract = 74,
        Left = 75,
        //Numpad4 = 75,
        Clear = 76,
        //Numpad5 = 76,
        Right = 77,
        //Numpad6 = 77,
        Add = 78,
        End = 79,
        //Numpad1 = 79,

        Down = 80,
        //Numpad2 = 80,
        Next = 81, // Page Down (Next)
        //PageDown = 81,
        //Numpad3 = 81,
        Insert = 82, // (Ins)
        //Numpad0 = 82,
        Delete = 83, // (Del)
        //Decimal = 83,
        PrintScreen = 84, // Print Screen (PrtSc)
        //Snapshot = 84,
        Oem102 = 86,
        F11 = 87,
        F12 = 88,

        LWin = 91,
        RWin = 92,
        Apps = 93,
        //Ereof = 93,
        Sleep = 95,
        Zoom = 98,
        Help = 99,

        F13 = 100,
        F14 = 101,
        //BrowserSearch = 101,
        F15 = 102,
        //BrowserFavorites = 102,
        F16 = 103,
        //BrowserRefresh = 103,
        F17 = 104,
        //BrowserStop = 104,
        F18 = 105,
        //BrowserForward = 105,
        F19 = 106,
        //BrowserBack = 106,
        F20 = 107,
        //LaunchApp1 = 107,
        F21 = 108,
        //LaunchMail = 108,
        F22 = 109,
        //SelectMedia = 109,

        F23 = 110,
        F24 = 118,

    }

    #endregion


    #region Hardware

    // Define HardwareInput struct
    [StructLayout(LayoutKind.Sequential)]
    public struct HardwareInput
    {
        internal int Msg;
        internal short ParamL;
        internal short ParamH;
    }

    #endregion


    /// <summary>
    /// https://blog.csdn.net/weixin_30490729/article/details/117178411
    /// </summary>
    public static class InputSimulator
    {

        public static bool KeyDown(ScanCodeShort scan)
        {
            return 0 != InputSimulator.SendInput(1, new Input[]
            {
                InputSimulator.GetInput(scan, KeyEvent.KeyDown | KeyEvent.ScanCode),
            }, Input.Size);
        }

        public static bool KeyUp(ScanCodeShort scan)
        {
            return 0 != InputSimulator.SendInput(1, new Input[]
            {
                InputSimulator.GetInput(scan, KeyEvent.KeyUp | KeyEvent.ScanCode),
            }, Input.Size);
        }


        public static bool Send(ScanCodeShort scan)
        {
            return 0 != InputSimulator.SendInput(1, new Input[1]
            {
                InputSimulator.GetInput(scan, KeyEvent.ScanCode)
            }, Input.Size);
        }

        public static bool Send(ScanCodeShort scan, ScanCodeShort scan2)
        {
            return 0 != InputSimulator.SendInput(2 + 2, new Input[]
            {
                InputSimulator.GetInput(scan, KeyEvent.KeyDown | KeyEvent.ScanCode),
                InputSimulator.GetInput(scan2, KeyEvent.KeyDown | KeyEvent.ScanCode),
                InputSimulator.GetInput(scan2, KeyEvent.KeyUp | KeyEvent.ScanCode),
                InputSimulator.GetInput(scan, KeyEvent.KeyUp | KeyEvent.ScanCode),
            }, Input.Size);
        }

        public static bool Send(ScanCodeShort scan, ScanCodeShort scan2, ScanCodeShort scan3)
        {
            return 0 != InputSimulator.SendInput(3 + 3, new Input[]
            {
                InputSimulator.GetInput(scan, KeyEvent.KeyDown | KeyEvent.ScanCode),
                InputSimulator.GetInput(scan2, KeyEvent.KeyDown | KeyEvent.ScanCode),
                InputSimulator.GetInput(scan3, KeyEvent.KeyDown | KeyEvent.ScanCode),
                InputSimulator.GetInput(scan3, KeyEvent.KeyUp | KeyEvent.ScanCode),
                InputSimulator.GetInput(scan2, KeyEvent.KeyUp | KeyEvent.ScanCode),
                InputSimulator.GetInput(scan, KeyEvent.KeyUp | KeyEvent.ScanCode),
            }, Input.Size);
        }

        public static bool Send(IList<ScanCodeShort> scans)
        {
            int count = scans.Count;
            switch (count)
            {
                case 0:
                    return false;
                case 1:
                    return InputSimulator.Send(scans[0]);
                case 2:
                    return InputSimulator.Send(scans[0], scans[1]);
                case 3:
                    return InputSimulator.Send(scans[0], scans[1], scans[2]);
                default:
                    {
                        int length = count + count;
                        Input[] inputs = new Input[length];

                        int index = 0;
                        foreach (ScanCodeShort item in scans)
                        {
                            inputs[index] = InputSimulator.GetInput(item, KeyEvent.KeyDown | KeyEvent.ScanCode);
                            inputs[length - 1 - index] = InputSimulator.GetInput(item, KeyEvent.KeyUp | KeyEvent.ScanCode);
                            index++;
                        }

                        return 0 != InputSimulator.SendInput((uint)length, inputs, Marshal.SizeOf(typeof(Input)));
                    }
            }
        }


        #region Native Methods

        private static Input GetInput(ScanCodeShort scan, KeyEvent flags) => new Input
        {
            Type = InputType.Keyboard,
            Union = new InputUnion
            {
                K = new KeyboardInput
                {
                    Scan = scan,
                    Flags = flags
                }
            }
        };

        // Declaration of external SendInput method
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] Input[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        private static extern IntPtr GetMessageExtraInfo();

        #endregion

    }
}