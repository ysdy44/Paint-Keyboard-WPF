using System.Collections.Generic;

namespace Paint_Keyboard.Elements
{
    /// <summary>
    /// <code>
    ///     public TextBlock CreateTextBlock()
    ///     {
    ///         int characterCode = 0xE10E;
    ///         return new TextBlock
    ///         {
    ///             Text = characterCode.ToGlyph(),
    ///             FontFamily = new FontFamily("Segoe MDL2 Assets")
    ///         };
    ///     }
    /// </code>
    /// </summary>
    public static class IconFontCharacter
    {
        
        // 0xE10E > "\uE10E"
        public static string ToGlyph(this int characterCode) => char.ConvertFromUtf32(characterCode);

        // 0xE10E > "E10E"
        public static string ToCodeKey(this int characterCode) => $"{characterCode:X4}";


        // string FontFamily = "Segoe MDL2 Assets";
        public static IEnumerable<int> CreateSegoeMDL2AssetsCharacterCodesList()
        {
            // U+000～U+0FF
            for (int code = 0xE001; code <= 0xE00C; code++) yield return code;
            for (int code = 0xE00E; code <= 0xE019; code++) yield return code;
            for (int code = 0xE052; code <= 0xE052; code++) yield return code;
            for (int code = 0xE07F; code <= 0xE07F; code++) yield return code;
            for (int code = 0xE081; code <= 0xE082; code++) yield return code;
            for (int code = 0xE08F; code <= 0xE08F; code++) yield return code;
            for (int code = 0xE094; code <= 0xE094; code++) yield return code;
            for (int code = 0xE096; code <= 0xE0A2; code++) yield return code;
            for (int code = 0xE0A5; code <= 0xE0A6; code++) yield return code;
            for (int code = 0xE0AB; code <= 0xE0AB; code++) yield return code;
            for (int code = 0xE0AD; code <= 0xE0AE; code++) yield return code;
            for (int code = 0xE0B4; code <= 0xE0B5; code++) yield return code;
            for (int code = 0xE0C4; code <= 0xE0C4; code++) yield return code;
            for (int code = 0xE0D5; code <= 0xE0D5; code++) yield return code;
            for (int code = 0xE0E2; code <= 0xE0E5; code++) yield return code;
            for (int code = 0xE0E7; code <= 0xE0E7; code++) yield return code;

            // U+100～U+1FF
            for (int code = 0xE100; code <= 0xE156; code++) yield return code;
            for (int code = 0xE158; code <= 0xE17D; code++) yield return code;
            for (int code = 0xE181; code <= 0xE1A8; code++) yield return code;
            for (int code = 0xE1AA; code <= 0xE1C0; code++) yield return code;
            for (int code = 0xE1C2; code <= 0xE1EA; code++) yield return code;
            for (int code = 0xE1EC; code <= 0xE1EF; code++) yield return code;
            for (int code = 0xE1F1; code <= 0xE1F7; code++) yield return code;
            for (int code = 0xE1FD; code <= 0xE1FD; code++) yield return code;

            // U+200～U+2FF
            for (int code = 0xE206; code <= 0xE206; code++) yield return code;
            for (int code = 0xE208; code <= 0xE20B; code++) yield return code;
            for (int code = 0xE211; code <= 0xE212; code++) yield return code;
            for (int code = 0xE224; code <= 0xE224; code++) yield return code;
            for (int code = 0xE228; code <= 0xE228; code++) yield return code;
            for (int code = 0xE248; code <= 0xE24A; code++) yield return code;
            for (int code = 0xE25A; code <= 0xE25E; code++) yield return code;
            for (int code = 0xE26B; code <= 0xE26C; code++) yield return code;
            for (int code = 0xE28F; code <= 0xE292; code++) yield return code;
            for (int code = 0xE294; code <= 0xE295; code++) yield return code;
            for (int code = 0xE297; code <= 0xE299; code++) yield return code;
            for (int code = 0xE29B; code <= 0xE29B; code++) yield return code;
            for (int code = 0xE2AC; code <= 0xE2B4; code++) yield return code;
            for (int code = 0xE2F6; code <= 0xE2F7; code++) yield return code;

            // U+700～U+7FF
            for (int code = 0xE700; code <= 0xE72E; code++) yield return code;
            for (int code = 0xE730; code <= 0xE730; code++) yield return code;
            for (int code = 0xE734; code <= 0xE735; code++) yield return code;
            for (int code = 0xE738; code <= 0xE756; code++) yield return code;
            for (int code = 0xE759; code <= 0xE769; code++) yield return code;
            for (int code = 0xE76B; code <= 0xE77C; code++) yield return code;
            for (int code = 0xE77F; code <= 0xE781; code++) yield return code;
            for (int code = 0xE783; code <= 0xE78C; code++) yield return code;
            for (int code = 0xE799; code <= 0xE799; code++) yield return code;
            for (int code = 0xE7A5; code <= 0xE7A8; code++) yield return code;
            for (int code = 0xE7AC; code <= 0xE7AD; code++) yield return code;
            for (int code = 0xE7B5; code <= 0xE7B5; code++) yield return code;
            for (int code = 0xE7B7; code <= 0xE7B8; code++) yield return code;
            for (int code = 0xE7BA; code <= 0xE7BA; code++) yield return code;
            for (int code = 0xE7BC; code <= 0xE7BC; code++) yield return code;
            for (int code = 0xE7BE; code <= 0xE7C1; code++) yield return code;
            for (int code = 0xE7C3; code <= 0xE7C9; code++) yield return code;
            for (int code = 0xE7DE; code <= 0xE7DE; code++) yield return code;
            for (int code = 0xE7E3; code <= 0xE7E3; code++) yield return code;
            for (int code = 0xE7E6; code <= 0xE7E8; code++) yield return code;
            for (int code = 0xE7EA; code <= 0xE7FD; code++) yield return code;

            // U+800～U+8FF
            for (int code = 0xE802; code <= 0xE806; code++) yield return code;
            for (int code = 0xE809; code <= 0xE80A; code++) yield return code;
            for (int code = 0xE80C; code <= 0xE80D; code++) yield return code;
            for (int code = 0xE80F; code <= 0xE80F; code++) yield return code;
            for (int code = 0xE811; code <= 0xE816; code++) yield return code;
            for (int code = 0xE819; code <= 0xE81F; code++) yield return code;
            for (int code = 0xE821; code <= 0xE823; code++) yield return code;
            for (int code = 0xE825; code <= 0xE826; code++) yield return code;
            for (int code = 0xE829; code <= 0xE830; code++) yield return code;
            for (int code = 0xE835; code <= 0xE836; code++) yield return code;
            for (int code = 0xE839; code <= 0xE89C; code++) yield return code;
            for (int code = 0xE89E; code <= 0xE8C6; code++) yield return code;
            for (int code = 0xE8C8; code <= 0xE8FF; code++) yield return code;

            // U+900～U+9FF
            for (int code = 0xE904; code <= 0xE916; code++) yield return code;
            for (int code = 0xE91B; code <= 0xE91C; code++) yield return code;
            for (int code = 0xE91F; code <= 0xE91F; code++) yield return code;
            for (int code = 0xE921; code <= 0xE929; code++) yield return code;
            for (int code = 0xE92C; code <= 0xE939; code++) yield return code;
            for (int code = 0xE93C; code <= 0xE93C; code++) yield return code;
            for (int code = 0xE93E; code <= 0xE93E; code++) yield return code;
            for (int code = 0xE943; code <= 0xE958; code++) yield return code;
            for (int code = 0xE95A; code <= 0xE95B; code++) yield return code;
            for (int code = 0xE95D; code <= 0xE95E; code++) yield return code;
            for (int code = 0xE960; code <= 0xE96A; code++) yield return code;
            for (int code = 0xE96D; code <= 0xE98A; code++) yield return code;
            for (int code = 0xE98F; code <= 0xE990; code++) yield return code;
            for (int code = 0xE992; code <= 0xE996; code++) yield return code;
            for (int code = 0xE998; code <= 0xE998; code++) yield return code;
            for (int code = 0xE99A; code <= 0xE99A; code++) yield return code;
            for (int code = 0xE9A1; code <= 0xE9A1; code++) yield return code;
            for (int code = 0xE9A9; code <= 0xE9BC; code++) yield return code;
            for (int code = 0xE9CA; code <= 0xE9CA; code++) yield return code;
            for (int code = 0xE9D9; code <= 0xE9D9; code++) yield return code;
            for (int code = 0xE9F3; code <= 0xE9F3; code++) yield return code;

            // U+A00～U+AFF
            for (int code = 0xEA14; code <= 0xEA14; code++) yield return code;
            for (int code = 0xEA1F; code <= 0xEA1F; code++) yield return code;
            for (int code = 0xEA21; code <= 0xEA21; code++) yield return code;
            for (int code = 0xEA24; code <= 0xEA24; code++) yield return code;
            for (int code = 0xEA35; code <= 0xEA35; code++) yield return code;
            for (int code = 0xEA37; code <= 0xEA3B; code++) yield return code;
            for (int code = 0xEA40; code <= 0xEA44; code++) yield return code;
            for (int code = 0xEA47; code <= 0xEA4C; code++) yield return code;
            for (int code = 0xEA4E; code <= 0xEA58; code++) yield return code;
            for (int code = 0xEA5B; code <= 0xEA5C; code++) yield return code;
            for (int code = 0xEA5E; code <= 0xEA65; code++) yield return code;
            for (int code = 0xEA69; code <= 0xEA6A; code++) yield return code;
            for (int code = 0xEA6C; code <= 0xEA6C; code++) yield return code;
            for (int code = 0xEA80; code <= 0xEA84; code++) yield return code;
            for (int code = 0xEA86; code <= 0xEA86; code++) yield return code;
            for (int code = 0xEA89; code <= 0xEA8F; code++) yield return code;
            for (int code = 0xEA91; code <= 0xEA95; code++) yield return code;
            for (int code = 0xEA97; code <= 0xEA99; code++) yield return code;
            for (int code = 0xEADF; code <= 0xEADF; code++) yield return code;

            // U+B00～U+BFF
            for (int code = 0xEB05; code <= 0xEB05; code++) yield return code;
            for (int code = 0xEB0F; code <= 0xEB0F; code++) yield return code;
            for (int code = 0xEB11; code <= 0xEB11; code++) yield return code;
            for (int code = 0xEB42; code <= 0xEB42; code++) yield return code;
            for (int code = 0xEB47; code <= 0xEB52; code++) yield return code;
            for (int code = 0xEB55; code <= 0xEB63; code++) yield return code;
            for (int code = 0xEB66; code <= 0xEB68; code++) yield return code;
            for (int code = 0xEB7E; code <= 0xEB7E; code++) yield return code;
            for (int code = 0xEB82; code <= 0xEB8D; code++) yield return code;
            for (int code = 0xEB90; code <= 0xEB91; code++) yield return code;
            for (int code = 0xEB95; code <= 0xEB97; code++) yield return code;
            for (int code = 0xEB9D; code <= 0xEBC0; code++) yield return code;
            for (int code = 0xEBC3; code <= 0xEBC6; code++) yield return code;
            for (int code = 0xEBD2; code <= 0xEBD2; code++) yield return code;
            for (int code = 0xEBD4; code <= 0xEBD9; code++) yield return code;
            for (int code = 0xEBDE; code <= 0xEBDE; code++) yield return code;
            for (int code = 0xEBE6; code <= 0xEBE7; code++) yield return code;
            for (int code = 0xEBFC; code <= 0xEC00; code++) yield return code;

            // U+C00～U+CFF
            for (int code = 0xEC02; code <= 0xEC02; code++) yield return code;
            for (int code = 0xEC05; code <= 0xEC0B; code++) yield return code;
            for (int code = 0xEC11; code <= 0xEC16; code++) yield return code;
            for (int code = 0xEC19; code <= 0xEC19; code++) yield return code;
            for (int code = 0xEC1B; code <= 0xEC1B; code++) yield return code;
            for (int code = 0xEC1E; code <= 0xEC1E; code++) yield return code;
            for (int code = 0xEC20; code <= 0xEC20; code++) yield return code;
            for (int code = 0xEC24; code <= 0xEC27; code++) yield return code;
            for (int code = 0xEC31; code <= 0xEC31; code++) yield return code;
            for (int code = 0xEC37; code <= 0xEC4A; code++) yield return code;
            for (int code = 0xEC4E; code <= 0xEC52; code++) yield return code;
            for (int code = 0xEC54; code <= 0xEC5C; code++) yield return code;
            for (int code = 0xEC61; code <= 0xEC61; code++) yield return code;
            for (int code = 0xEC64; code <= 0xEC64; code++) yield return code;
            for (int code = 0xEC6D; code <= 0xEC6D; code++) yield return code;
            for (int code = 0xEC71; code <= 0xEC72; code++) yield return code;
            for (int code = 0xEC74; code <= 0xEC77; code++) yield return code;
            for (int code = 0xEC7A; code <= 0xEC7A; code++) yield return code;
            for (int code = 0xEC7E; code <= 0xEC81; code++) yield return code;
            for (int code = 0xEC87; code <= 0xEC88; code++) yield return code;
            for (int code = 0xEC8A; code <= 0xEC8A; code++) yield return code;
            for (int code = 0xEC87; code <= 0xEC88; code++) yield return code;
            for (int code = 0xEC8F; code <= 0xEC8F; code++) yield return code;
            for (int code = 0xEC92; code <= 0xEC92; code++) yield return code;
            for (int code = 0xECA5; code <= 0xECA5; code++) yield return code;
            for (int code = 0xECA7; code <= 0xECA7; code++) yield return code;
            for (int code = 0xECAA; code <= 0xECAA; code++) yield return code;
            for (int code = 0xECC4; code <= 0xECCD; code++) yield return code;
            for (int code = 0xECE7; code <= 0xECE9; code++) yield return code;
            for (int code = 0xECC4; code <= 0xECCD; code++) yield return code;
            for (int code = 0xECF0; code <= 0xECF1; code++) yield return code;
            for (int code = 0xECF3; code <= 0xECF3; code++) yield return code;

            // U+D00～U+DFF
            for (int code = 0xED0C; code <= 0xED0D; code++) yield return code;
            for (int code = 0xED10; code <= 0xED10; code++) yield return code;
            for (int code = 0xED15; code <= 0xED15; code++) yield return code;
            for (int code = 0xED1E; code <= 0xED1F; code++) yield return code;
            for (int code = 0xED28; code <= 0xED28; code++) yield return code;
            for (int code = 0xED2A; code <= 0xED33; code++) yield return code;
            for (int code = 0xED39; code <= 0xED3A; code++) yield return code;
            for (int code = 0xED3C; code <= 0xED3D; code++) yield return code;
            for (int code = 0xED41; code <= 0xED44; code++) yield return code;
            for (int code = 0xED47; code <= 0xED47; code++) yield return code;
            for (int code = 0xED28; code <= 0xED28; code++) yield return code;
            for (int code = 0xED4C; code <= 0xED4D; code++) yield return code;
            for (int code = 0xED53; code <= 0xED67; code++) yield return code;
            for (int code = 0xEDA2; code <= 0xEDB1; code++) yield return code;
            for (int code = 0xEDB3; code <= 0xEDB5; code++) yield return code;
            for (int code = 0xEDC6; code <= 0xEDC6; code++) yield return code;
            for (int code = 0xEDE1; code <= 0xEDE2; code++) yield return code;
            for (int code = 0xEDFB; code <= 0xEDFB; code++) yield return code;

            // U+E00～U+EFF
            for (int code = 0xEE35; code <= 0xEE35; code++) yield return code;
            for (int code = 0xEE3F; code <= 0xEE40; code++) yield return code;
            for (int code = 0xEE56; code <= 0xEE57; code++) yield return code;
            for (int code = 0xEE63; code <= 0xEE65; code++) yield return code;
            for (int code = 0xEE71; code <= 0xEE71; code++) yield return code;
            for (int code = 0xEE77; code <= 0xEE77; code++) yield return code;
            for (int code = 0xEE79; code <= 0xEE7A; code++) yield return code;
            for (int code = 0xEE92; code <= 0xEE94; code++) yield return code;

            // U+F00～U+FFF
            for (int code = 0xEF15; code <= 0xEF19; code++) yield return code;
            for (int code = 0xEF1F; code <= 0xEF20; code++) yield return code;
        }

        // string FontFamily = "Segoe UI Symbol";
        public static IEnumerable<int> CreateSegoeUISymbolCharacterCodesList()
        {
            // U+100～U+300
            for (int code = 0xE100; code <= 0xE156; code++) yield return code;
            for (int code = 0xE158; code <= 0xE1FE; code++) yield return code;
            for (int code = 0xE200; code <= 0xE236; code++) yield return code;
            for (int code = 0xE239; code <= 0xE23A; code++) yield return code;
            for (int code = 0xE241; code <= 0xE26C; code++) yield return code;
            for (int code = 0xE2E6; code <= 0xE271; code++) yield return code;
            for (int code = 0xE27E; code <= 0xE292; code++) yield return code;
            for (int code = 0xE294; code <= 0xE295; code++) yield return code;
        }
    }
}