﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.Chapter3
{
    public class Page4 : IStaticCodeBook
    {
        public int Dimensions = 2;

        public byte[] LengthList = {
            2, 3, 3, 6, 6, 0, 0, 0, 0, 0, 4, 4, 6, 6, 0, 0,
            0, 0, 0, 4, 4, 6, 6, 0, 0, 0, 0, 0, 5, 5, 6, 6,
            0, 0, 0, 0, 0, 0, 0, 6, 6, 0, 0, 0, 0, 0, 0, 0,
            7, 8, 0, 0, 0, 0, 0, 0, 0, 7, 7, 0, 0, 0, 0, 0,
            0, 0, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0
        };

        public CodeBookMapType MapType = CodeBookMapType.Implicit;
        public int QuantMin = -531628032;
        public int QuantDelta = 1611661312;
        public int Quant = 4;
        public int QuantSequenceP = 0;

        public int[] QuantList = {
            4,
            3,
            5,
            2,
            6,
            1,
            7,
            0,
            8
        };
    }
}