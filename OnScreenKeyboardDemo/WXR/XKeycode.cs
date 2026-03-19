using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnScreenKeyboardDemo.WXR
{
    public static class XKeycode
    {
        public static string ToKeyCombo(string inKey)
        {
            string ans = "K,";

            string upperCase = "50,";

            //inKey = inKey.Replace("{^}", "");

            //KEY_CTRL_L(37),
            if (inKey.Contains("^"))
            {
                inKey.Replace("^", "");
                ans += "37,";
            }
            //KEY_ALT_L(64),
            if (inKey.Contains("%"))
            {
                inKey.Replace("%", "");
                ans += "64,";
            }
            //KEY_ESC(9)
            if (inKey == "{escape}")
            {
                ans += "9";
            }
            //KEY_1(10),
            if (inKey == "1")
            {
                ans += "10";
            }
            if (inKey == "{!}")
            {
                ans += upperCase + "10";
            }
            //KEY_2(11),
            if (inKey == "2")
            {
                ans += "11";
            }
            if (inKey == "{@}")
            {
                ans += upperCase + "11";
            }
            //KEY_3(12),
            if (inKey == "3")
            {
                ans += "12";
            }
            if (inKey == "{#}")
            {
                ans += upperCase + "12";
            }
            //KEY_4(13),
            if (inKey == "4")
            {
                ans += "13";
            }
            //KEY_CAPS_LOCK(66),
            if (inKey == "{CAPS}")
            {
                ans += "66";
            }
            //KEY_5(14),
            if (inKey == "5")
            {
                ans += "14";
            }
            //KEY_6(15),
            if (inKey == "6")
            {
                ans += "15";
            }
            //KEY_7(16),
            if (inKey == "7")
            {
                ans += "16";
            }
            //KEY_8(17),
            if (inKey == "8")
            {
                ans += "17";
            }
            if (inKey == "{MULTIPLY}")
            {
                ans += upperCase + "17";
            }
            //KEY_9(18),
            if (inKey == "9")
            {
                ans += "18";
            }
            if (inKey == "{(}")
            {
                ans += upperCase + "18";
            }
            //KEY_0(19),
            if (inKey == "0")
            {
                ans += "19";
            }
            if (inKey == "{)}")
            {
                ans += upperCase + "19";
            }
            //KEY_MINUS(20),
            if (inKey == "{SUBTRACT}")
            {
                ans += "20";
            }
            if (inKey == "{_}")
            {
                ans += upperCase + "20";
            }
            //KEY_EQUAL(21),
            if (inKey == "{=}")
            {
                ans += "21";
            }
            if (inKey == "{ADD}")
            {
                ans += upperCase + "21";
            }
            //KEY_BKSP(22),
            if (inKey == "{BACKSPACE}")
            {
                ans += "22";
            }
            //KEY_TAB(23),
            if (inKey == "{tab}")
            {
                ans += "23";
            }
            //KEY_Q(24),
            if (inKey == "q")
            {
                ans += "24";
            }
            if (inKey == "Q")
            {
                ans += upperCase + "24";
            }
            //KEY_W(25),
            if (inKey == "w")
            {
                ans += "25";
            }
            if (inKey == "W")
            {
                ans += upperCase + "25";
            }
            //KEY_E(26),
            if (inKey == "e")
            {
                ans += "26";
            }
            if (inKey == "E")
            {
                ans += upperCase + "26";
            }
            //KEY_R(27),
            if (inKey == "r")
            {
                ans += "27";
            }
            if (inKey == "R")
            {
                ans += upperCase + "27";
            }
            //KEY_T(28),
            if (inKey == "t")
            {
                ans += "28";
            }
            if (inKey == "T")
            {
                ans += upperCase + "28";
            }
            //KEY_Y(29),
            if (inKey == "y")
            {
                ans += "29";
            }
            if (inKey == "Y")
            {
                ans += upperCase + "29";
            }
            //KEY_U(30),
            if (inKey == "u")
            {
                ans += "30";
            }
            if (inKey == "U")
            {
                ans += upperCase + "30";
            }
            //KEY_I(31),
            if (inKey == "i")
            {
                ans += "31";
            }
            if (inKey == "I")
            {
                ans += upperCase + "31";
            }
            //KEY_O(32),
            if (inKey == "o")
            {
                ans += "32";
            }
            if (inKey == "O")
            {
                ans += upperCase + "32";
            }
            //KEY_P(33),
            if (inKey == "p")
            {
                ans += "33";
            }
            if (inKey == "P")
            {
                ans += upperCase + "33";
            }
            //KEY_BRACKET_LEFT(34),
            if (inKey == "{[}")
            {
                ans += "34";
            }
            if (inKey == "{{}")
            {
                ans += upperCase + "34";
            }
            //KEY_BRACKET_RIGHT(35),
            if (inKey == "{]}")
            {
                ans += "35";
            }
            if (inKey == "{}}")
            {
                ans += upperCase + "35";
            }
            //KEY_ENTER(36),
            if (inKey == "{enter}")
            {
                ans += "36";
            }
            //KEY_A(38),
            if (inKey == "a")
            {
                ans += "38";
            }
            if (inKey == "A")
            {
                ans += upperCase + "38";
            }
            //KEY_S(39),
            if (inKey == "s")
            {
                ans += "39";
            }
            if (inKey == "S")
            {
                ans += upperCase + "39";
            }
            //KEY_D(40),
            if (inKey == "d")
            {
                ans += "40";
            }
            if (inKey == "D")
            {
                ans += upperCase + "40";
            }
            //KEY_F(41),
            if (inKey == "f")
            {
                ans += "41";
            }
            if (inKey == "F")
            {
                ans += upperCase + "41";
            }
            //KEY_G(42),
            if (inKey == "g")
            {
                ans += "42";
            }
            if (inKey == "G")
            {
                ans += upperCase + "42";
            }
            //KEY_H(43),
            if (inKey == "h")
            {
                ans += "43";
            }
            if (inKey == "H")
            {
                ans += upperCase + "43";
            }
            //KEY_J(44),
            if (inKey == "j")
            {
                ans += "44";
            }
            if (inKey == "J")
            {
                ans += upperCase + "44";
            }
            //KEY_K(45),
            if (inKey == "k")
            {
                ans += "45";
            }
            if (inKey == "K")
            {
                ans += upperCase + "45";
            }
            //KEY_L(46),
            if (inKey == "l")
            {
                ans += "46";
            }
            if (inKey == "L")
            {
                ans += upperCase + "46";
            }
            //KEY_SEMICOLON(47), ;
            if (inKey == "{;}")
            {
                ans += "47";
            }
            if (inKey == "{:}")
            {
                ans += upperCase + "47";
            }
            //KEY_APOSTROPHE(48), '
            if (inKey == "{'}")
            {
                ans += "48";
            }
            if (inKey == "{\"}")
            {
                ans += upperCase + "48";
            }
            //KEY_GRAVE(49), `~
            if (inKey == "{`}")
            {
                ans += "49";
            }
            if (inKey == "{~}")
            {
                ans += upperCase + "49";
            }
            //KEY_BACKSLASH(51), \?
            if (inKey == "{/}")
            {
                ans += "51";
            }
            if (inKey == "{|}")
            {
                ans += upperCase + "51";
            }
            //KEY_Z(52),
            if (inKey == "z")
            {
                ans += "52";
            }
            if (inKey == "Z")
            {
                ans += upperCase + "52";
            }
            //KEY_X(53),
            if (inKey == "x")
            {
                ans += "53";
            }
            if (inKey == "X")
            {
                ans += upperCase + "53";
            }
            //KEY_C(54),
            if (inKey == "c")
            {
                ans += "54";
            }
            if (inKey == "C")
            {
                ans += upperCase + "54";
            }
            //KEY_V(55),
            if (inKey == "v")
            {
                ans += "55";
            }
            if (inKey == "V")
            {
                ans += upperCase + "55";
            }
            //KEY_B(56),
            if (inKey == "b")
            {
                ans += "56";
            }
            if (inKey == "B")
            {
                ans += upperCase + "56";
            }
            //KEY_N(57),
            if (inKey == "n")
            {
                ans += "57";
            }
            if (inKey == "N")
            {
                ans += upperCase + "57";
            }
            //KEY_M(58),
            if (inKey == "m")
            {
                ans += "58";
            }
            if (inKey == "M")
            {
                ans += upperCase + "58";
            }
            //KEY_COMMA(59),
            if (inKey == "{,}")
            {
                ans += "59";
            }
            if (inKey == "{<}")
            {
                ans += upperCase + "59";
            }
            //KEY_PERIOD(60),
            if (inKey == "{.}")
            {
                ans += "60";
            }
            if (inKey == "{>}")
            {
                ans += upperCase + "60";
            }
            //KEY_SLASH(61),
            if (inKey == "{//}")
            {
                ans += "61";
            }
            if (inKey == "{?}")
            {
                ans += upperCase + "61";
            }
            //KEY_SPACE(65),
            if (inKey == "{SPACE}")
            {
                ans += "65";
            }
            //KEY_UP(111),
            if (inKey == "{UP}")
            {
                ans += "111";
            }
            //KEY_DOWN(116),
            if (inKey == "{DOWN}")
            {
                ans += "116";
            }
            //KEY_LEFT(113),
            if (inKey == "{LEFT}")
            {
                ans += "113";
            }
            //KEY_RIGHT(114),
            if (inKey == "{RIGHT}")
            {
                ans += "114";
            }
            //KEY_PRIOR(112), (PAGE UP)]
            if (inKey == "{PGUP}")
            {
                ans += "112";
            }
            //KEY_NEXT(117), (PAGE NEXT)
            if (inKey == "{PGDN}")
            {
                ans += "117";
            }
            //KEY_NUM_LOCK(77),
            if (inKey == "{NUMLCK}")
            {
                ans += "77";
            }
            //KEY_PRTSCN(107),
            if (inKey == "{PRTSCN}")
            {
                ans += "107";
            }
            //KEY_DEL(119),
            if (inKey == "{DELETE}")
            {
                ans += "119";
            }

            //Need a home?
            //KEY_KP_MULTIPLY(63),
            //KEY_KP_7(79),
            //KEY_KP_8(80)
            //KEY_KP_9(81),
            //KEY_KP_SUBTRACT(82),
            //KEY_KP_4(83),
            //KEY_KP_5(84),
            //KEY_KP_6(85),
            //KEY_KP_ADD(86),
            //KEY_KP_1(87),
            //KEY_KP_2(88),
            //KEY_KP_3(89),
            //KEY_KP_0(90),
            //KEY_KP_DEL(91),
            //KEY_KP_ENTER(104),
            //KEY_KP_DIVIDE(106),
            //KEY_SHIFT_R(62),
            //KEY_CTRL_R(105),
            //KEY_ALT_R(108),
            //KEY_SCROLL_LOCK(78),

            //Unsuable symbols?
            /*
             *   %
             *   ^
             *   &
             *   $
             */

            //Handled elsewhere:
            //KEY_F1(67),
            //KEY_F2(68),
            //KEY_F3(69),
            //KEY_F4(70),
            //KEY_F5(71),
            //KEY_F6(72),
            //KEY_F7(73),
            //KEY_F8(74),
            //KEY_F9(75),
            //KEY_F10(76),
            //KEY_F11(95),
            //KEY_F12(96),
            //KEY_HOME(110),
            //KEY_END(115),
            //KEY_INSERT(118),
            //KEY_SHIFT_L(50),

            //Never used
            //KEY_MAX(KEY_DEL.id);
            //KEY_NONE(0)

            return ans;
        }
    }
}
