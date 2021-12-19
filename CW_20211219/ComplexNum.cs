using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20211219
{
    class ComplexNum
    {
        public double Re { get; set; }
        public double Im { get; set; }


        public ComplexNum()
        {
            Re = 0;
            Im = 0;
        }
        
        public ComplexNum(double _re, double _im)
        {
            this.Re = _re;
            this.Im = _im;
        }

        // OPERATOR OVERLOAD
        // 1. MULTIPLICATION

        public static ComplexNum operator*(ComplexNum _firstCimplexNum, ComplexNum _secondComplexNum)
        {
            double resRe = _firstCimplexNum.Re * _secondComplexNum.Re - _firstCimplexNum.Im * _secondComplexNum.Im; 
            double resIm = _firstCimplexNum.Re * _secondComplexNum.Im + _firstCimplexNum.Im * _secondComplexNum.Re;
            return new ComplexNum(resRe, resIm);
        }

        public static ComplexNum operator*(ComplexNum _complexNum, double _num)
        {
            return new ComplexNum(_complexNum.Re * _num, _complexNum.Im * _num);
        }
        
        public static ComplexNum operator*(double _num, ComplexNum _complexNum)
        {
            return new ComplexNum(_complexNum.Re * _num, _complexNum.Im * _num);
        }

        //2. Unary minus overload 
        public static ComplexNum operator-(ComplexNum _complexNum)
        {
            return new ComplexNum(-_complexNum.Re, -_complexNum.Im);
        }
        public static ComplexNum operator++(ComplexNum _complexNum)
        {
            _complexNum.Re++;
            _complexNum.Im++;
            return new ComplexNum(_complexNum.Re, _complexNum.Im);
        }
        public static ComplexNum operator--(ComplexNum _complexNum)
        {
            _complexNum.Re--;
            _complexNum.Im--;
            return new ComplexNum(_complexNum.Re, _complexNum.Im);
        }


        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }



    }
}
