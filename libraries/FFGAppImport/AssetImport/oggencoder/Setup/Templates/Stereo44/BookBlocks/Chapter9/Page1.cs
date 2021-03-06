﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.Chapter9
{
    public class Page1 : IStaticCodeBook
    {
        public int Dimensions = 4;

        public byte[] LengthList = {
            1, 5, 5, 0, 5, 5, 0, 5, 5, 6, 8, 8, 0, 9, 8, 0,
            9, 8, 6, 8, 8, 0, 8, 9, 0, 8, 9, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 5, 8, 8, 0, 7, 7, 0, 8, 8, 5, 8, 8,
            0, 7, 8, 0, 8, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5,
            9, 8, 0, 8, 8, 0, 7, 7, 5, 8, 9, 0, 8, 8, 0, 7,
            7
        };

        public CodeBookMapType MapType = CodeBookMapType.Implicit;
        public int QuantMin = -535822336;
        public int QuantDelta = 1611661312;
        public int Quant = 2;
        public int QuantSequenceP = 0;

        public int[] QuantList = {
            1,
            0,
            2
        };
    }
}