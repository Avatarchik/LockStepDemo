﻿using System.Collections.Generic;

namespace IM
{
    public static class Math
    {
        public const int FACTOR = 1000;
        public const int SQR_FACTOR = FACTOR * FACTOR;
        public static Number PI = new Number(3, 14159);     //3.14159265358979323846264338327950288f
        public static Number TWO_PI = new Number(6, 283185); //6.28318530717958647692528676655900576f
        public static Number ROOT_PI = new Number(1, 7724);//1.772453850905516027f
        public static Number HALF_PI = new Number(1, 57079);//1.57079632679489661923132169163975144f
        public static Number MIN_LENGTH = new Number(-23);
        public static Number MAX_LENGTH = new Number(23);
        public static Number MIN_ANGLE = -TWO_PI * new Number(128);
        public static Number MAX_ANGLE = TWO_PI * new Number(128);

        public static void CheckLengthRange(Number x, string name = "")
        {
            CheckRange(x, MIN_LENGTH, MAX_LENGTH, name);
        }
        public static void CheckAngleRange(Number x, string name = "")
        {
            CheckRange(x, MIN_ANGLE, MAX_ANGLE, name);
        }
        public static void CheckRange(Number x, Number min, Number max, string name = "")
        {
            CheckRange((long)x.raw, (long)min.raw, (long)max.raw, name);
        }
        public static void CheckRange(long x, long min, long max, string name = "")
        {
            if (x < min || x > max)
            {
                throw new System.ArgumentOutOfRangeException(
                    string.Format("Number {0}:{1} out of range:({2}, {3})", name, x, min, max));
            }
        }
        public static void CheckRange(Vector3 vec)
        {
            CheckLengthRange(vec.x, "Vector3.x");
            CheckLengthRange(vec.y, "Vector3.y");
            CheckLengthRange(vec.z, "Vector3.z");
        }
        public static void CheckNotEqual(Number x, Number r, string name = "")
        {
            if (x == r)
            {
                throw new System.ArgumentException(
                    string.Format("Number {0}:{1} equals {2}", name, x, r));
            }
        }

        public static Number Deg2Rad(Number degrees)
        {
            const long X = (long)(0.01745329251994329576923690768489 * FACTOR * FACTOR);
            return Number.Raw((int)Math.RndDiv(Math.RndDiv(degrees.raw * X, FACTOR), FACTOR));
        }

        public static Number Rad2Deg(Number radians)
        {
            const long X = (long)(57.295779513082320876798154814105 * SQR_FACTOR * SQR_FACTOR);
            return Number.Raw((int)(radians.raw * X / SQR_FACTOR / SQR_FACTOR));
            //const long X = (long)(57.296 * FACTOR);
            //return Number.Raw((int)(Math.RndDiv(radians.raw * X, FACTOR)));
        }

        public static Number Min(Number x, Number y)
        {
            return y < x ? y : x;
        }

        public static long Min(long x, long y)
        {
            return y < x ? y : x;
        }

        public static Number Max(Number x, Number y)
        {
            return y > x ? y : x;
        }

        public static long Max(long x, long y)
        {
            return y > x ? y : x;
        }

        public static Number Clamp(Number x, Number min, Number max)
        {
            if (x < min)
                return min;
            else if (x > max)
                return max;
            else
                return x;
        }

        public static long Clamp(long x, long min, long max)
        {
            if (x < min)
                return min;
            else if (x > max)
                return max;
            else
                return x;
        }

        public static Number Sign(Number x)
        {
            return x >= Number.zero ? Number.one : -Number.one;
        }

        public static long Sign(long x)
        {
            return x >= 0L ? 1L : -1L;
        }

        public static long RndDiv(long x, long y)
        {
            if (x == 0L)
                return 0L;
            if (y == 0L)
                throw new System.DivideByZeroException();

            long sign = Sign(x) * Sign(y);
            long absX = Abs(x);
            long absY = Abs(y);
            long q = absX / absY;
            long m = absX % absY;
            long m2 = m * 2L;
            if (m2 > absY)
                return sign * (q + 1L);
            else if (m2 < absY)
                return sign * q;
            else
            {
                long r = q + 1L;
                r = (r >> 1) << 1;
                return sign * r;
            }
        }

        public static Number Abs(Number x)
        {
            return Number.Raw(System.Math.Abs(x.raw));
        }

        public static long Abs(long x)
        {
            return System.Math.Abs(x);
        }

        public static Number Cos(Number radians)
        {
            CheckAngleRange(radians, "Cos(radians)");
            return fastCos(radians);
        }

        public static Number Sin(Number radians)
        {
            CheckAngleRange(radians, "Sin(radians)");
            return fastSin(radians);
        }

        public static Number Asin(Number x)
        {
            CheckRange(x, -Number.one, Number.one, "Asin(x)");
            return fastAsin(x);
        }

        public static Number Acos(Number x)
        {
            CheckRange(x, -Number.one, Number.one, "Acos(x)");
            return Number.Raw(1571) - fastAsin(x);
        }

        public static Number Atan(Number x)
        {
            Number rad = Number.zero;
            if (x > new Number(3037))
                rad = HALF_PI;
            else if (x < new Number(-3037))
                rad = -HALF_PI;
            else
            {
                long A = (long)x.raw * x.raw * Math.SQR_FACTOR;     //4 POF
                long B = (long)x.raw * x.raw + Math.SQR_FACTOR;     //2 POF
                long C = Math.RndDiv(A, B);     //2 POF
                int sqrSinA = (int)C;
                int sinA = Sqrt(sqrSinA);       //1 POF
                rad = Asin(Number.Raw(sinA)) * Sign(x);
            }
            return rad;
        }

        public static Number Atan2(Number y, Number x)
        {
            CheckRange(y, Number.Raw(int.MinValue), Number.Raw(int.MaxValue), "Atan2(y)");

            if (x == Number.zero)
            {
                CheckNotEqual(y, Number.zero, "Atan2(y) when x == 0");
                return HALF_PI * Sign(y);
            }
            Number sign = Sign(y) * Sign(x);
            Number result = Abs(Atan(y / x)) * sign;
            if (y < Number.zero && x < Number.zero)
                result -= PI;
            else if (y >= Number.zero && x < Number.zero)
                result += PI;
            CheckRange(result, -Math.PI, Math.PI, "Atan2(result)");
            return result;
        }

        static Number cos_52s(Number x)
        {
            long xx = (long)x.raw * x.raw;
            Utils.Trace(string.Format("x:{0} xx:{1}", x, xx));

            const long A = (long)(0.9999932946f * SQR_FACTOR);
            const long B = (long)(-0.4999124376f * SQR_FACTOR);
            const long C = (long)(0.0414877472f * SQR_FACTOR);
            const long D = (long)(-0.0012712095f * SQR_FACTOR);
            Utils.Trace(string.Format("A:{0} B:{1} C:{2} D:{3}", A, B, C, D));

            long r1 = C + Math.RndDiv(xx * D, SQR_FACTOR);
            long r2 = B + Math.RndDiv(xx * r1, SQR_FACTOR);
            long r3 = A + Math.RndDiv(xx * r2, SQR_FACTOR);
            Utils.Trace(string.Format("r1:{0} r2:{1} r3:{2}", r1, r2, r3));

            return Number.Raw((int)Math.RndDiv(r3, FACTOR));
        }

        static Number fastCos(Number radians)
        {
            Number angle = Abs(radians % TWO_PI);

            if (angle < HALF_PI)
                return cos_52s(angle);
            if (angle < PI)
                return -cos_52s(PI - angle);
            if (angle < (HALF_PI * new Number(3)))
                return -cos_52s(angle - PI);

            return cos_52s(TWO_PI - angle);
        }

        static Number fastSin(Number radians)
        {
            return fastCos(HALF_PI - radians);
        }

#if UNITY_EDITOR
        [UnityEditor.MenuItem("TriFunc/Generate Asin Table")]
        static void GenerateAsinTable()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("static int[] asinTable = { ");
            for (int i = 0; i <= Math.FACTOR; ++i)
            {
                int result = UnityEngine.Mathf.RoundToInt(UnityEngine.Mathf.Asin((float)i / Math.FACTOR) * Math.FACTOR);
                if (i % 10 == 0)
                    builder.Append("\n");
                builder.Append(result.ToString().PadLeft(4, ' '));
                if (i != Math.FACTOR)
                    builder.Append(", ");
            }
            builder.Append("};");
            System.IO.File.AppendAllText("Assets/Code/IMath/Math.cs", builder.ToString());
        }

        [UnityEditor.MenuItem("TriFunc/Generate Acos Table")]
        static void GenerateAcosTable()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("static int[] acosTable = { ");
            for (int i = 0; i <= Math.FACTOR; ++i)
            {
                int result = UnityEngine.Mathf.RoundToInt(UnityEngine.Mathf.Acos((float)i / Math.FACTOR) * Math.FACTOR);
                if (i % 10 == 0)
                    builder.Append("\n");
                builder.Append(result.ToString().PadLeft(4, ' '));
                if (i != Math.FACTOR)
                    builder.Append(", \t");
            }
            builder.Append("};");
            System.IO.File.AppendAllText("Assets/Code/IMath/Math.cs", builder.ToString());
        }

        [UnityEditor.MenuItem("TriFunc/Generate Atan Table")]
        static void GenerateAtanTable()
        {
            Stack<KeyValuePair<KeyValuePair<int, int>, int>> table = new Stack<KeyValuePair<KeyValuePair<int, int>, int>>();
            for (int i = 0; i <= Math.FACTOR * 32; ++i)
            {
                int result = UnityEngine.Mathf.RoundToInt(UnityEngine.Mathf.Atan((float)i / Math.FACTOR) * Math.FACTOR);
                if (table.Count == 0)
                    table.Push(new KeyValuePair<KeyValuePair<int, int>, int>(new KeyValuePair<int, int>(i, i), result));
                else
                {
                    var top = table.Peek();
                    if (top.Value == result)
                    {
                        table.Pop();
                        table.Push(new KeyValuePair<KeyValuePair<int, int>, int>(new KeyValuePair<int, int>(top.Key.Key, i), result));
                    }
                    else
                    {
                        table.Push(new KeyValuePair<KeyValuePair<int, int>, int>(new KeyValuePair<int, int>(i, i), result));
                    }
                }
            }

            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("static int[] atanTable = { \n");
            foreach (KeyValuePair<KeyValuePair<int, int>,int> pair in table)
            {
                builder.Append(string.Format("({0}, {1}) -> {2}\n", pair.Key.Key, pair.Key.Value, pair.Value));
            }
            builder.Append("};");
            System.IO.File.AppendAllText("Assets/Code/IMath/Math.cs", builder.ToString());
        }
#endif

        static int[] asinTable = { 
               0,    1,    2,    3,    4,    5,    6,    7,    8,    9, 
              10,   11,   12,   13,   14,   15,   16,   17,   18,   19, 
              20,   21,   22,   23,   24,   25,   26,   27,   28,   29, 
              30,   31,   32,   33,   34,   35,   36,   37,   38,   39, 
              40,   41,   42,   43,   44,   45,   46,   47,   48,   49, 
              50,   51,   52,   53,   54,   55,   56,   57,   58,   59, 
              60,   61,   62,   63,   64,   65,   66,   67,   68,   69, 
              70,   71,   72,   73,   74,   75,   76,   77,   78,   79, 
              80,   81,   82,   83,   84,   85,   86,   87,   88,   89, 
              90,   91,   92,   93,   94,   95,   96,   97,   98,   99, 
             100,  101,  102,  103,  104,  105,  106,  107,  108,  109, 
             110,  111,  112,  113,  114,  115,  116,  117,  118,  119, 
             120,  121,  122,  123,  124,  125,  126,  127,  128,  129, 
             130,  131,  132,  133,  134,  135,  136,  137,  138,  139, 
             140,  141,  142,  143,  145,  146,  147,  148,  149,  150, 
             151,  152,  153,  154,  155,  156,  157,  158,  159,  160, 
             161,  162,  163,  164,  165,  166,  167,  168,  169,  170, 
             171,  172,  173,  174,  175,  176,  177,  178,  179,  180, 
             181,  182,  183,  184,  185,  186,  187,  188,  189,  190, 
             191,  192,  193,  194,  195,  196,  197,  198,  199,  200, 
             201,  202,  203,  204,  205,  206,  207,  209,  210,  211, 
             212,  213,  214,  215,  216,  217,  218,  219,  220,  221, 
             222,  223,  224,  225,  226,  227,  228,  229,  230,  231, 
             232,  233,  234,  235,  236,  237,  238,  239,  240,  241, 
             242,  243,  244,  245,  246,  248,  249,  250,  251,  252, 
             253,  254,  255,  256,  257,  258,  259,  260,  261,  262, 
             263,  264,  265,  266,  267,  268,  269,  270,  271,  272, 
             273,  274,  275,  277,  278,  279,  280,  281,  282,  283, 
             284,  285,  286,  287,  288,  289,  290,  291,  292,  293, 
             294,  295,  296,  297,  298,  299,  301,  302,  303,  304, 
             305,  306,  307,  308,  309,  310,  311,  312,  313,  314, 
             315,  316,  317,  318,  319,  320,  322,  323,  324,  325, 
             326,  327,  328,  329,  330,  331,  332,  333,  334,  335, 
             336,  337,  338,  339,  341,  342,  343,  344,  345,  346, 
             347,  348,  349,  350,  351,  352,  353,  354,  355,  357, 
             358,  359,  360,  361,  362,  363,  364,  365,  366,  367, 
             368,  369,  370,  371,  373,  374,  375,  376,  377,  378, 
             379,  380,  381,  382,  383,  384,  385,  387,  388,  389, 
             390,  391,  392,  393,  394,  395,  396,  397,  398,  400, 
             401,  402,  403,  404,  405,  406,  407,  408,  409,  410, 
             412,  413,  414,  415,  416,  417,  418,  419,  420,  421, 
             422,  424,  425,  426,  427,  428,  429,  430,  431,  432, 
             433,  435,  436,  437,  438,  439,  440,  441,  442,  443, 
             444,  446,  447,  448,  449,  450,  451,  452,  453,  454, 
             456,  457,  458,  459,  460,  461,  462,  463,  465,  466, 
             467,  468,  469,  470,  471,  472,  473,  475,  476,  477, 
             478,  479,  480,  481,  483,  484,  485,  486,  487,  488, 
             489,  490,  492,  493,  494,  495,  496,  497,  498,  500, 
             501,  502,  503,  504,  505,  506,  508,  509,  510,  511, 
             512,  513,  514,  516,  517,  518,  519,  520,  521,  522, 
             524,  525,  526,  527,  528,  529,  531,  532,  533,  534, 
             535,  536,  538,  539,  540,  541,  542,  543,  545,  546, 
             547,  548,  549,  550,  552,  553,  554,  555,  556,  557, 
             559,  560,  561,  562,  563,  565,  566,  567,  568,  569, 
             570,  572,  573,  574,  575,  576,  578,  579,  580,  581, 
             582,  584,  585,  586,  587,  588,  590,  591,  592,  593, 
             594,  596,  597,  598,  599,  600,  602,  603,  604,  605, 
             607,  608,  609,  610,  611,  613,  614,  615,  616,  618, 
             619,  620,  621,  622,  624,  625,  626,  627,  629,  630, 
             631,  632,  634,  635,  636,  637,  639,  640,  641,  642, 
             644,  645,  646,  647,  649,  650,  651,  652,  654,  655, 
             656,  657,  659,  660,  661,  662,  664,  665,  666,  667, 
             669,  670,  671,  673,  674,  675,  676,  678,  679,  680, 
             682,  683,  684,  685,  687,  688,  689,  691,  692,  693, 
             694,  696,  697,  698,  700,  701,  702,  704,  705,  706, 
             708,  709,  710,  712,  713,  714,  716,  717,  718,  719, 
             721,  722,  723,  725,  726,  727,  729,  730,  732,  733, 
             734,  736,  737,  738,  740,  741,  742,  744,  745,  746, 
             748,  749,  750,  752,  753,  755,  756,  757,  759,  760, 
             761,  763,  764,  766,  767,  768,  770,  771,  773,  774, 
             775,  777,  778,  780,  781,  782,  784,  785,  787,  788, 
             789,  791,  792,  794,  795,  797,  798,  799,  801,  802, 
             804,  805,  807,  808,  810,  811,  812,  814,  815,  817, 
             818,  820,  821,  823,  824,  826,  827,  829,  830,  832, 
             833,  835,  836,  838,  839,  841,  842,  844,  845,  847, 
             848,  850,  851,  853,  854,  856,  857,  859,  860,  862, 
             863,  865,  866,  868,  869,  871,  873,  874,  876,  877, 
             879,  880,  882,  884,  885,  887,  888,  890,  891,  893, 
             895,  896,  898,  899,  901,  903,  904,  906,  908,  909, 
             911,  912,  914,  916,  917,  919,  921,  922,  924,  926, 
             927,  929,  931,  932,  934,  936,  937,  939,  941,  942, 
             944,  946,  948,  949,  951,  953,  954,  956,  958,  960, 
             961,  963,  965,  967,  968,  970,  972,  974,  976,  977, 
             979,  981,  983,  985,  986,  988,  990,  992,  994,  995, 
             997,  999, 1001, 1003, 1005, 1007, 1008, 1010, 1012, 1014, 
            1016, 1018, 1020, 1022, 1024, 1026, 1027, 1029, 1031, 1033, 
            1035, 1037, 1039, 1041, 1043, 1045, 1047, 1049, 1051, 1053, 
            1055, 1057, 1059, 1061, 1063, 1065, 1068, 1070, 1072, 1074, 
            1076, 1078, 1080, 1082, 1084, 1086, 1089, 1091, 1093, 1095, 
            1097, 1100, 1102, 1104, 1106, 1108, 1111, 1113, 1115, 1117, 
            1120, 1122, 1124, 1127, 1129, 1131, 1134, 1136, 1138, 1141, 
            1143, 1146, 1148, 1151, 1153, 1156, 1158, 1160, 1163, 1166, 
            1168, 1171, 1173, 1176, 1178, 1181, 1184, 1186, 1189, 1192, 
            1194, 1197, 1200, 1203, 1205, 1208, 1211, 1214, 1217, 1220, 
            1223, 1226, 1229, 1232, 1235, 1238, 1241, 1244, 1247, 1250, 
            1253, 1256, 1260, 1263, 1266, 1270, 1273, 1276, 1280, 1283, 
            1287, 1291, 1294, 1298, 1302, 1305, 1309, 1313, 1317, 1321, 
            1325, 1329, 1334, 1338, 1342, 1347, 1351, 1356, 1361, 1365, 
            1370, 1376, 1381, 1386, 1392, 1397, 1403, 1409, 1416, 1422, 
            1429, 1437, 1444, 1452, 1461, 1471, 1481, 1493, 1508, 1526, 
            1571
        };

        static Number fastAsin(Number x)
        {
            Number sign = Sign(x);
            x = Clamp(Abs(x), Number.zero, Number.one);
            Number result = Number.Raw(asinTable[x.raw]);
            return sign * result;
        }

        public static float fastInvSqrt(float x)
        {
            unsafe
            {
                float f = x;
                float xhalf = x * 0.5f;
                uint* p = (uint*)(&x);
                uint i = 0x5f3759df - (*p >> 1);
                float* pf = (float*)(&i);
                f = *pf;
                f = f * (1.5f - xhalf * f * f);
                return f;
            }
        }

        static int[] sqrtTable = {
            0,    16,  22,  27,  32,  35,  39,  42,  45,  48,  50,  53,  55,  57,
            59,   61,  64,  65,  67,  69,  71,  73,  75,  76,  78,  80,  81,  83,
            84,   86,  87,  89,  90,  91,  93,  94,  96,  97,  98,  99, 101, 102,
            103, 104, 106, 107, 108, 109, 110, 112, 113, 114, 115, 116, 117, 118,
            119, 120, 121, 122, 123, 124, 125, 126, 128, 128, 129, 130, 131, 132,
            133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 144, 145,
            146, 147, 148, 149, 150, 150, 151, 152, 153, 154, 155, 155, 156, 157,
            158, 159, 160, 160, 161, 162, 163, 163, 164, 165, 166, 167, 167, 168,
            169, 170, 170, 171, 172, 173, 173, 174, 175, 176, 176, 177, 178, 178,
            179, 180, 181, 181, 182, 183, 183, 184, 185, 185, 186, 187, 187, 188,
            189, 189, 190, 191, 192, 192, 193, 193, 194, 195, 195, 196, 197, 197,
            198, 199, 199, 200, 201, 201, 202, 203, 203, 204, 204, 205, 206, 206,
            207, 208, 208, 209, 209, 210, 211, 211, 212, 212, 213, 214, 214, 215,
            215, 216, 217, 217, 218, 218, 219, 219, 220, 221, 221, 222, 222, 223,
            224, 224, 225, 225, 226, 226, 227, 227, 228, 229, 229, 230, 230, 231,
            231, 232, 232, 233, 234, 234, 235, 235, 236, 236, 237, 237, 238, 238,
            239, 240, 240, 241, 241, 242, 242, 243, 243, 244, 244, 245, 245, 246,
            246, 247, 247, 248, 248, 249, 249, 250, 250, 251, 251, 252, 252, 253,
            253, 254, 254, 255
        };

        public static int Sqrt(int n)
        {
            if (n < 0)
                throw new System.ArgumentException("Argument of Sqrt shouldn't be negative." + n);
            int xn;
            if (n >= 0x7FFEA810) return 0xB504;
            if (n >= 0x10000)
            {
                if (n >= 0x1000000)
                {
                    if (n >= 0x10000000)
                    {
                        if (n >= 0x40000000)
                        {
                            xn = sqrtTable[n >> 24] << 8;
                        }
                        else
                        {
                            xn = sqrtTable[n >> 22] << 7;
                        }
                    }
                    else
                    {
                        if (n >= 0x4000000)
                        {
                            xn = sqrtTable[n >> 20] << 6;
                        }
                        else
                        {
                            xn = sqrtTable[n >> 18] << 5;
                        }
                    }

                    xn = (xn + 1 + (n / xn)) >> 1;
                    xn = (xn + 1 + (n / xn)) >> 1;
                    return ((xn * xn) > n) ? --xn : xn;
                }
                else
                {
                    if (n >= 0x100000)
                    {
                        if (n >= 0x400000)
                        {
                            xn = sqrtTable[n >> 16] << 4;
                        }
                        else
                        {
                            xn = sqrtTable[n >> 14] << 3;
                        }
                    }
                    else
                    {
                        if (n >= 0x40000)
                        {
                            xn = sqrtTable[n >> 12] << 2;
                        }
                        else
                        {
                            xn = sqrtTable[n >> 10] << 1;
                        }
                    }

                    xn = (xn + 1 + (n / xn)) >> 1;
                    return ((xn * xn) > n) ? --xn : xn;
                }
            }
            else
            {
                if (n >= 0x100)
                {
                    if (n >= 0x1000)
                    {
                        if (n >= 0x4000)
                        {
                            xn = (sqrtTable[n >> 8]) + 1;
                        }
                        else
                        {
                            xn = (sqrtTable[n >> 6] >> 1) + 1;
                        }
                    }
                    else
                    {
                        if (n >= 0x400)
                        {
                            xn = (sqrtTable[n >> 4] >> 2) + 1;
                        }
                        else
                        {
                            xn = (sqrtTable[n >> 2] >> 3) + 1;
                        }
                    }
                    return ((xn * xn) > n) ? --xn : xn;
                }
                else
                {
                    if (n >= 0)
                    {
                        return sqrtTable[n] >> 4;
                    }
                }
            }
            return -1;
        }
    }
}
