using System;
using System.Collections.Generic;
using System.Text;

namespace IRobo.Domain
{
    public class PointMap
    {
        public bool p00 { get; set; }
        public bool p01 { get; set; }
        public bool p02 { get; set; }
        public bool p03 { get; set; }
        public bool p04 { get; set; }
        public bool p10 { get; set; }
        public bool p11 { get; set; }
        public bool p12 { get; set; }
        public bool p13 { get; set; }
        public bool p14 { get; set; }
        public bool p20 { get; set; }
        public bool p21 { get; set; }
        public bool p22 { get; set; }
        public bool p23 { get; set; }
        public bool p24 { get; set; }
        public bool p30 { get; set; }
        public bool p31 { get; set; }
        public bool p32 { get; set; }
        public bool p33 { get; set; }
        public bool p34 { get; set; }
        public bool p40 { get; set; }
        public bool p41 { get; set; }
        public bool p42 { get; set; }
        public bool p43 { get; set; }
        public bool p44 { get; set; }

        public void ClearPoint()
        {
            this.p00 = false;
            this.p01 = false;
            this.p02 = false;
            this.p03 = false;
            this.p04 = false;
            this.p10 = false;
            this.p11 = false;
            this.p12 = false;
            this.p13 = false;
            this.p14 = false;
            this.p20 = false;
            this.p21 = false;
            this.p22 = false;
            this.p23 = false;
            this.p24 = false;
            this.p30 = false;
            this.p31 = false;
            this.p32 = false;
            this.p33 = false;
            this.p34 = false;
            this.p40 = false;
            this.p41 = false;
            this.p42 = false;
            this.p43 = false;
            this.p44 = false;
        }

        public void SetPoint(int PositionX, int PositionY)
        {
            ClearPoint();

            var point = string.Format("{0}{1}", PositionX, PositionY);

            switch (point)
            {
                case "00":
                    this.p00 = true;
                    break;
                case "01":
                    this.p01 = true;
                    break;
                case "02":
                    this.p02 = true;
                    break;
                case "03":
                    this.p03 = true;
                    break;
                case "04":
                    this.p04 = true;
                    break;

                case "10":
                    this.p10 = true;
                    break;
                case "11":
                    this.p11 = true;
                    break;
                case "12":
                    this.p12 = true;
                    break;
                case "13":
                    this.p13 = true;
                    break;
                case "14":
                    this.p14 = true;
                    break;

                case "20":
                    this.p20 = true;
                    break;
                case "21":
                    this.p21 = true;
                    break;
                case "22":
                    this.p22 = true;
                    break;
                case "23":
                    this.p23 = true;
                    break;
                case "24":
                    this.p24 = true;
                    break;

                case "30":
                    this.p30 = true;
                    break;
                case "31":
                    this.p31 = true;
                    break;
                case "32":
                    this.p32 = true;
                    break;
                case "33":
                    this.p33 = true;
                    break;
                case "34":
                    this.p34 = true;
                    break;

                case "40":
                    this.p40 = true;
                    break;
                case "41":
                    this.p41 = true;
                    break;
                case "42":
                    this.p42 = true;
                    break;
                case "43":
                    this.p43 = true;
                    break;
                case "44":
                    this.p44 = true;
                    break;

                default:
                    break;
            }
        }
    }
}
