using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //フィートとメートルの単位変換クラス
    public static class FeetConverter
    {
        //定数 1ft = 0.3048 m
        private const double ratio = 0.3048;

        //メートルからフィートを求める toFeet
        public static double FromMetar(double metar){
            return metar / ratio;
        }
        //フィートからメートルを求める FromFeet
        public static double ToMetar(double feet) {
            return feet * ratio;
        }
    }
}
