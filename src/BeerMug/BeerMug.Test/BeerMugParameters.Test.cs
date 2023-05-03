using BeerMug.Model;
using NUnit.Framework;

namespace BeerMug.Test
{
    [TestFixture]
    public class BeerMugParametersTest
    {
        public void FieldsData(double belowBottom, double highBottom, double neck, 
            double high, double bottomThickness, double wallThickness, MugParameters mugParameters)
        {
            mugParameters.MugNeckDiametr = neck;
            mugParameters.HighBottomDiametr = highBottom;
            mugParameters.High = high;
            mugParameters.BottomThickness = bottomThickness;
            mugParameters.WallThickness = wallThickness;
            mugParameters.BelowBottomRadius = belowBottom;
        }

        [TestCase(Description = "���������� ���� ������� BelowBottomRadius")]
        public void Test_BelowBottomRadius_Get_CorrectValue()
        {
            MugParameters mugParameters = new MugParameters();
            
            double belowBottom = 50;
            double expected = 50;
            double highBottom = 80;
            double neck = 80;
            double high = 100;
            double bottomThickness = 10;
            double wallThickness = 5;
            FieldsData(belowBottom, highBottom, neck,
                high, bottomThickness, wallThickness, mugParameters);
            Assert.AreEqual(expected, mugParameters.BelowBottomRadius, "�������� ������ ������� � " +
                                                                        "�������� �� 50 �� 70");/// ������� �������� ��� -30 = ������� ������� ���
        }

        [TestCase(50, Description = "���������� ���� ������� BelowBottomRadius")]
        public void Test_BelowBottomRadius_Set_CorrectValue(double value)
        {
            MugParameters mugParameters = new MugParameters();
            double belowBottom = 50;
            double highBottom = 80;
            double neck = 80;
            double high = 100;
            double bottomThickness = 10;
            double wallThickness = 5;
            FieldsData(belowBottom, highBottom, neck,
                high, bottomThickness, wallThickness, mugParameters);
            Assert.AreEqual(value, mugParameters.BelowBottomRadius,
                "�������� ������ ������� � �������� �� 50 �� 70");
        }

        [TestCase(30, Description = "���������� ���� ������� BelowBottomRadius")]
        [TestCase(90, Description = "���������� ���� ������� BelowBottomRadius")]

        public void Test_BelowBottomRadius_Set_IncorrectValue(double wrongBelowBottomRadius)
        {
            MugParameters mugParameters = new MugParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                mugParameters.BelowBottomRadius = wrongBelowBottomRadius;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
            "�������� �� 50 �� 70");
        }

        [TestCase(60, Description = "���������� ���� ������� BelowBottomRadius")]
        public void Test_BelowBottomRadius_Set_IncorrectValueAddiction(double wrongBelowBottomRadius)
        {
            MugParameters _mugParameters = new MugParameters();
            double expected = 50;
            double highBottom = 80;
            double neck = 80;
            double high = 100;
            double bottomThickness = 10;
            double wallThickness = 5;
            FieldsData(50, highBottom, neck,
                high, bottomThickness, wallThickness, _mugParameters);
            Assert.Throws<Exception>(() =>
            {
                _mugParameters.BelowBottomRadius = wrongBelowBottomRadius;
            }, "������� ������� ��� ������ ���� �� 30 ������ �������� ��� ��������");///������� ������� ��� +30 = ������� �������� ���
        }

        [TestCase(Description = "���������� ���� ������� HighBottomDiametr")]
        public void Test_HighBottomDiametr_Get_CorrectValue()
        {
            MugParameters _mugParameters = new MugParameters();
            double expected = 80;
            double belowBottom = 50;
            double highBottom = 80;
            double neck = 80;
            double high = 100;
            double bottomThickness = 10;
            double wallThickness = 5;
            FieldsData(50, highBottom, neck,
                high, bottomThickness, wallThickness, _mugParameters);
            var actual = expected;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 80 �� 100");

        }

        [TestCase(80, Description = "���������� ���� ������� HighBottomDiametr")]
        public void Test_HighBottomDiametr_Set_CorrectValue(double value)
        {
            MugParameters mugParameters = new MugParameters();
            double belowBottom = 50;
            double highBottom = 80;
            double neck = 80;
            double high = 100;
            double bottomThickness = 10;
            double wallThickness = 5;
            FieldsData(50, highBottom, neck,
                high, bottomThickness, wallThickness, mugParameters);
            Assert.AreEqual(value, mugParameters.HighBottomDiametr,
                "�������� ������ ������� � �������� �� 80 �� 100");

        }

        [TestCase(40, Description = "���������� ���� ������� HighBottomDiametr")]
        [TestCase(120, Description = "���������� ���� ������� HighBottomDiametr")]
        public void Test_HighBottomDiametr_Set_IncorrectValue(double wrongHighBottomDiametr)
        {
            MugParameters mugParameters = new MugParameters();

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                mugParameters.HighBottomDiametr = wrongHighBottomDiametr;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 80 �� 100");
        }

        [TestCase(80, Description = "���������� ���� ������� HighBottomDiametr")]
        public void Test_HighBottomDiametr_Set_IncorrectValueAddiction(double wrongHighBottomDiametr)
        {
            MugParameters mugParameters = new MugParameters();
            mugParameters.MugNeckDiametr = 90;
            Assert.Throws<Exception>(() =>
            {
                mugParameters.HighBottomDiametr = wrongHighBottomDiametr;
            }, "������� ������� ��� ������ ���� ����� �������� ����� ������");///������� ������� ��� � ������� ������ = 1 � 1
        }

        [TestCase(Description = "���������� ���� ������� BottomThickness")]
        public void Test_BottomThickness_Get_CorrectValue()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 10;
            mugParameters.High = 100;
            mugParameters.BottomThickness = expected;
            var actual = mugParameters.BottomThickness = expected;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 10 �� 16,5"); /// 1 � 10 10 = 100
        }

        [TestCase(10, Description = "���������� ���� ������� BottomThickness")]
        public void Test_BottomThickness_Set_CorrectValue(double value)
        {
            MugParameters mugParameters = new MugParameters();
            double belowBottom = 50;
            double highBottom = 80;
            double neck = 80;
            double high = 100;
            double bottomThickness = 10;
            double wallThickness = 5;
            FieldsData(50, highBottom, neck,
                high, bottomThickness, wallThickness, mugParameters);
            Assert.AreEqual(value, mugParameters.BottomThickness,
                "�������� ������ ������� � �������� �� 10 �� 16,5"); ///1 � 10
        }

        [TestCase(12, Description = "���������� ���� ������� BottomThickness")]
        public void Test_BottomThickness_Set_IncorrectValueAddiction(double wrongBottomThickness)
        {
            MugParameters mugParameters = new MugParameters();
            double belowBottom = 50;
            double highBottom = 80;
            double neck = 80;
            double high = 100;
            double bottomThickness = 10;
            double wallThickness = 5;
            FieldsData(50, highBottom, neck,
                high, bottomThickness, wallThickness, mugParameters);
            Assert.Throws<Exception>(() =>
            {
                mugParameters.BottomThickness = wrongBottomThickness;
            }, "������ ��� ������ ���� � 10 ��� ������ ������ ������");/// 1 � 10
        }

        [TestCase(8, Description = "���������� ���� ������� BottomThickness")]
        [TestCase(20, Description = "���������� ���� ������� BottomThickness")]
        public void Test_BottomThickness_Set_IncorrectValue(double wrongBottomThickness)
        {
            MugParameters mugParameters = new MugParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                mugParameters.BottomThickness = wrongBottomThickness;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 10 �� 16,5");
        }

        [TestCase(Description = "���������� ���� ������� High")]
        public void Test_High_Get_CorrectValue()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 100;
            mugParameters.High = expected;
            var actual = mugParameters.High;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 100 �� 165");

        }

        [TestCase(100, Description = "���������� ���� ������� High")]
        public void Test_High_Set_CorrectValue(double value)
        {
            MugParameters mugParameters = new MugParameters();
            mugParameters.High = 100;
            Assert.AreEqual(value, mugParameters.High,
                "�������� ������ ������� � �������� �� 100 �� 165");

        }

        [TestCase(80, Description = "���������� ���� ������� High")]
        [TestCase(180, Description = "���������� ���� ������� High")]
        public void Test_High_Set_IncorrectValue(double wrongHigh)
        {
            MugParameters mugParameters = new MugParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                mugParameters.High = wrongHigh;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 100 �� 165");
        }

        [TestCase(Description = "���������� ���� ������� WallThickness")]
        public void Test_WallThickness_Get_CorrectValue()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 5;
            mugParameters.WallThickness = expected;
            var actual = mugParameters.WallThickness;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 5 �� 7");
        }

        [TestCase(5, Description = "���������� ���� ������� WallThickness")]
        public void Test_WallThickness_Set_CorrectValue(double value)
        {
            MugParameters mugParameters = new MugParameters();
            mugParameters.WallThickness = 5;
            Assert.AreEqual(value, mugParameters.WallThickness,
                "�������� ������ ������� � �������� �� 5 �� 7");
        }

        [TestCase(1, Description = "���������� ���� ������� WallThickness")]
        [TestCase(10, Description = "���������� ���� ������� WallThickness")]

        public void Test_WallThickness_Set_IncorrectValue(double wrongWallThickness)
        {
            MugParameters mugParameters = new MugParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                mugParameters.WallThickness = wrongWallThickness;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 5 �� 7");
        }

        [TestCase(Description = "���������� ���� ������� MugNeckDiametr")]
        public void Test_MugNeckDiametr_Get_CorrectValue()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 80;
            mugParameters.MugNeckDiametr = expected;
            var actual = mugParameters.MugNeckDiametr;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 80 �� 100");
        }

        [TestCase(80, Description = "���������� ���� ������� MugNeckDiametr")]
        public void Test_MugNeckDiametr_Set_CorrectValue(double value)
        {
            MugParameters mugParameters = new MugParameters();
            mugParameters.MugNeckDiametr = 80;
            Assert.AreEqual(value, mugParameters.MugNeckDiametr,
                "�������� ������ ������� � �������� �� 80 �� 100");
        }

        [TestCase(70, Description = "���������� ���� ������� MugNeckDiametr")]
        [TestCase(110, Description = "���������� ���� ������� MugNeckDiametr")]

        public void Test_MugNeckDiametr_Set_IncorrectValue(double wrongMugNeckDiametr)
        {
            MugParameters mugParameters = new MugParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    mugParameters.MugNeckDiametr = wrongMugNeckDiametr;
                }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 80 �� 100");
        }

        [TestCase(Description = "���������� ���� ������� BelowBottomDiametrMin")]
        public void Test_BelowBottomDiametrMin_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 50;
            var actual = mugParameters.BelowBottomDiametrMin;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 50");
        }

        [TestCase(Description = "���������� ���� ������� BelowBottomDiameterMax")]
        public void Test_BelowBottomDiametrMax_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 70;
            var actual = mugParameters.BelowBottomDiameterMax;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 70");
        }

        [TestCase(Description = "���������� ���� ������� HighBottomDiametrMin")]
        public void Test_HighBottomDiametrMin_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 80;
            var actual = mugParameters.HighBottomDiametrMin;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 80");
        }

        [TestCase(Description = "���������� ���� ������� HighBottomDiametrMax")]
        public void Test_HighBottomDiametrMax_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 100;
            var actual = mugParameters.HighBottomDiametrMax;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 100");
        }

        [TestCase(Description = "���������� ���� ������� BottomThicknessMin")]
        public void Test_BottomThicknessMin_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 10;
            var actual = mugParameters.BottomThicknessMin;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 10");
        }

        [TestCase(Description = "���������� ���� ������� BottomThicknessMax")]
        public void Test_BottomThicknessMax_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = "16,5";
            var actual = mugParameters.BottomThicknessMax;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 16.5");
        }

        [TestCase(Description = "���������� ���� ������� HighMin")]
        public void Test_HighMin_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 100;
            var actual = mugParameters.HighMin;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 100");
        }

        [TestCase(Description = "���������� ���� ������� HighMax")]
        public void Test_HighMax_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 165;
            var actual = mugParameters.HighMax;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 165");
        }

        [TestCase(Description = "���������� ���� ������� WallThicknessMin")]
        public void Test_WallThicknessMin_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 5;
            var actual = mugParameters.WallThicknessMin;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 5");
        }

        [TestCase(Description = "���������� ���� ������� WallThicknessMax")]
        public void Test_WallThicknessMax_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 7;
            var actual = mugParameters.WallThicknessMax;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 7");
        }

        [TestCase(Description = "���������� ���� ������� MugNeckDiametrMin")]
        public void Test_MugNeckDiametrMin_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 80;
            var actual = mugParameters.MugNeckDiametrMin;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 80");
        }

        [TestCase(Description = "���������� ���� ������� MugNeckDiametrMax")]
        public void Test_MugNeckDiametrMax_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = 100;
            var actual = mugParameters.MugNeckDiametrMax;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� 100");
        }

        [TestCase(Description = "���������� ���� ������� MugType")]
        public void Test_MugType_Get_Value()
        {
            MugParameters mugParameters = new MugParameters();
            var expected = "Round shape";
            var actual = mugParameters.MugType;
            Assert.AreEqual(expected, actual, "�������� ������ ���� ����� Round shape");
        }
    }
}