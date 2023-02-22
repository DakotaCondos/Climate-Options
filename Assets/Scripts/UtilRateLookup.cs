using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilRateLookup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            public class Rates
            {
                public Rates(double? electric, double? gas)
                {
                    if (electric == null) { throw new ArgumentNullException(nameof(electric)); }
                    if (gas == null) { throw new ArgumentNullException(nameof(gas)); }

                }
                public double Electric { get; set; }
                public double Gas { get; set; }

            }

            int[] zipcodes = { 36104, 99801, 85001, 72201, 95814, 80202, 06103, 19901, 32301, 30303,
                               96813, 83702, 62701, 46225, 50309, 67207, 40601, 70802, 04330, 21401,
                               02201, 48933, 55102, 39205, 65101, 59623, 68502, 89701, 03301, 08608,
                               87501, 12207, 27601, 58501, 43215, 73102, 97301, 17101, 02903, 29217,
                               57501, 37219, 78701, 84111, 05602, 23219, 98507, 25301, 53703, 82001};

            Dictionary<int, Rates> myBill = new();

            for (int zip = 0; zip < zipcodes.Length; zip++)
            {
                myBill.Add(zipcodes[zip], GetRates(zipcodes[zip]));
            }
            public static Rates GetRates(int zip)
            {
                double ele = 0;
                double gas = 0;


                if (zip == 36104)
                {
                    Rates al = new(142.17, 40.41);
                    return al;
                }
                else if (zip == 99801)
                {
                    Rates ak = new(142.17, 40.41);
                    return ak;
                }
                else if (zip == 85001)
                {
                    Rates az = new(137.14, 19.51);
                    return az;
                }
                else if (zip == 72201)
                {
                    Rates ar = new(126.69, 42.65);
                    return ar;
                }
                else if (zip == 95814)
                {
                    Rates ca = new(96.72, 36.01);
                    return ca;
                }
                else if (zip == 80202)
                {
                    Rates co = new(104.6, 30.25);
                    return co;
                }
                else if (zip == 06103)
                {
                    Rates ct = new(113.94, 53.84);
                    return ct;
                }
                else if (zip == 19901)
                {
                    Rates de = new(142.23, 60.55);
                    return de;
                }
                else if (zip == 32301)
                {
                    Rates fl = new(144.45, 15.68);
                    return fl;
                }
                else if (zip == 30303)
                {
                    Rates ge = new(121.1, 52.26);
                    return ge;
                }
                else if (zip == 96813)
                {
                    Rates hi = new(118.03, 9.44);
                    return hi;
                }
                else if (zip == 83702)
                {
                    Rates id = new(92.90, 35.80);
                    return id;
                }
                else if (zip == 62701)
                {
                    Rates il = new(124.51, 52.87);
                    return il;
                }
                else if (zip == 46225)
                {
                    Rates ind = new(116.19, 64.32);
                    return ind;
                }
                else if (zip == 50309)
                {
                    Rates ia = new(106.04, 35.11);
                    return ia;
                }
                else if (zip == 67207)
                {
                    Rates ks = new(117.88, 54.14);
                    return ks;
                }
                else if (zip == 40601)
                {
                    Rates ky = new(127.54, 38.56);
                    return ky;
                }
                else if (zip == 70802)
                {
                    Rates la = new(134.17, 21.59);
                    return la;
                }
                else if (zip == 04330)
                {
                    Rates me = new(79.08, 30.51);
                    return me;
                }
                else if (zip == 21401)
                {
                    Rates md = new(184.69, 27.42);
                    return md;
                }
                else if (zip == 02201)
                {
                    Rates ma = new(75.51, 46.97);
                    return ma;
                }
                else if (zip == 48933)
                {
                    Rates mi = new(105.49, 58.55);
                    return mi;
                }
                else if (zip == 55102)
                {
                    Rates mn = new(97.45, 45.24);
                    return mn;
                }
                else if (zip == 39205)
                {
                    Rates ms = new(124.91, 41.70);
                    return ms;
                }
                else if (zip == 65101)
                {
                    Rates mo = new(101.47, 35.55);
                    return mo;
                }
                else if (zip == 59623)
                {
                    Rates mt = new(81.27, 31.38);
                    return mt;
                }
                else if (zip == 68502)
                {
                    Rates ne = new(99.15, 47.07);
                    return ne;
                }
                else if (zip == 89701)
                {
                    Rates nv = new(0, 0);
                    return nv;
                }
                else if (zip == 03301)
                {
                    Rates nh = new(88.89, 50.95);
                    return nh;
                }
                else if (zip == 08608)
                {
                    Rates nj = new(144.77, 46.28);
                    return nj;
                }
                else if (zip == 87501)
                {
                    Rates nm = new(136, 25.55);
                    return nm;
                }
                else if (zip == 12207)
                {
                    Rates ny = new(102.73, 32.55);
                    return ny;
                }
                else if (zip == 27601)
                {
                    Rates nc = new(130.14, 39.46);
                    return nc;
                }
                else if (zip == 58501)
                {
                    Rates nd = new(97.39, 41.05);
                    return nd;
                }
                else if (zip == 43215)
                {
                    Rates oh = new(108.93, 55.99);
                    return oh;
                }
                else if (zip == 73102)
                {
                    Rates ok = new(115.94, 45.72);
                    return ok;
                }
                else if (zip == 97301)
                {
                    Rates ore = new(96.21, 30.01);
                    return ore;
                }
                else if (zip == 17101)
                {
                    Rates pa = new(115.9, 33.49);
                    return pa;
                }
                else if (zip == 02903)
                {
                    Rates ri = new(0, 0);
                    return ri;
                }
                else if (zip == 29217)
                {
                    Rates sc = new(172.86, 23.11);
                    return sc;
                }
                else if (zip == 57501)
                {
                    Rates sd = new(115.68, 58.99);
                    return sd;
                }
                else if (zip == 37219)
                {
                    Rates tn = new(132.00, 38.43);
                    return tn;
                }
                else if (zip == 78701)
                {
                    Rates tx = new(140.81, 29.37);
                    return tx;
                }
                else if (zip == 84111)
                {
                    Rates ut = new(89.75, 60.94);
                    return ut;
                }
                else if (zip == 05602)
                {
                    Rates vt = new(79.60, 43.35);
                    return vt;
                }
                else if (zip == 23219)
                {
                    Rates va = new(141.81, 38.09);
                    return va;
                }
                else if (zip == 99004)
                {
                    Rates wa = new(100.95, 21.49);
                    return wa;
                }
                else if (zip == 25301)
                {
                    Rates wv = new(127.12, 37.57);
                    return wv;
                }
                else if (zip == 53703)
                {
                    Rates wi = new(99.01, 41.26);
                    return wi;
                }
                else if (zip == 82001)
                {
                    Rates wy = new(101.46, 56.24);
                    return wy;
                }
                else
                {
                    Rates rate = new(ele, gas);
                    return rate;
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
