using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrintLabel_OPPO;

namespace PrintLabel_OPPO.Unit.DB
{
    class QTYsql
    {
        public static string sql(Main.Model model, string sn)
        {
            switch (model)
            {
                case Main.Model.pallet:
                    return $@"WITH pallet AS(
SELECT child_sn
FROM SHIP.view_packed
WHERE model='pallet'
AND parent_sn='{sn}')

,carton AS(
SELECT view_packed.child_sn
FROM SHIP.view_packed
JOIN pallet ON view_packed.parent_sn=pallet.child_sn
WHERE view_packed.model='carton')

,pack AS(
SELECT view_packed.child_sn
FROM SHIP.view_packed
JOIN carton ON view_packed.parent_sn=carton.child_sn
WHERE view_packed.model='pack')

,tray AS(
SELECT view_packed.child_sn,view_packed.p_date
FROM SHIP.view_packed
JOIN pack ON view_packed.parent_sn=pack.child_sn
WHERE view_packed.model='tray')

SELECT COUNT(*)::INT FROM tray";

                case Main.Model.carton:
                    return $@"WITH carton AS(
SELECT child_sn
FROM SHIP.view_packed
WHERE model='carton'
AND parent_sn='{sn}')

,pack AS(
SELECT view_packed.child_sn
FROM SHIP.view_packed
JOIN carton ON view_packed.parent_sn=carton.child_sn
WHERE view_packed.model='pack')

,tray AS(
SELECT view_packed.child_sn,view_packed.p_date
FROM SHIP.view_packed
JOIN pack ON view_packed.parent_sn=pack.child_sn
WHERE view_packed.model='tray')

SELECT COUNT(*)::INT FROM tray";

                case Main.Model.pack:
                    return $@"WITH pack AS(
SELECT child_sn
FROM SHIP.view_packed
WHERE model='pack'
AND parent_sn='{sn}')

,tray AS(
SELECT view_packed.child_sn,view_packed.p_date
FROM SHIP.view_packed
JOIN pack ON view_packed.parent_sn=pack.child_sn
WHERE view_packed.model='tray')

SELECT COUNT(*)::INT FROM tray";

                case Main.Model.tray:
                    return $@"WITH tray AS(
SELECT child_sn
FROM SHIP.view_packed
WHERE model='tray'
AND parent_sn='{sn}')

SELECT COUNT(*)::INT FROM tray";

                default:
                    return $"'{model}' model is false";
            }
        }

        public static string sql(Main2.Model model, string sn)
        {
            switch (model)
            {
                case Main2.Model.pallet:
                    return $@"WITH pallet AS(
SELECT child_sn
FROM SHIP.view_packed
WHERE model='pallet'
AND parent_sn='{sn}')

,carton AS(
SELECT view_packed.child_sn
FROM SHIP.view_packed
JOIN pallet ON view_packed.parent_sn=pallet.child_sn
WHERE view_packed.model='carton')

,pack AS(
SELECT view_packed.child_sn
FROM SHIP.view_packed
JOIN carton ON view_packed.parent_sn=carton.child_sn
WHERE view_packed.model='pack')

,tray AS(
SELECT view_packed.child_sn,view_packed.p_date
FROM SHIP.view_packed
JOIN pack ON view_packed.parent_sn=pack.child_sn
WHERE view_packed.model='tray')

SELECT COUNT(*)::INT FROM tray";

                case Main2.Model.carton:
                    return $@"WITH carton AS(
SELECT child_sn
FROM SHIP.view_packed
WHERE model='carton'
AND parent_sn='{sn}')

,pack AS(
SELECT view_packed.child_sn
FROM SHIP.view_packed
JOIN carton ON view_packed.parent_sn=carton.child_sn
WHERE view_packed.model='pack')

,tray AS(
SELECT view_packed.child_sn,view_packed.p_date
FROM SHIP.view_packed
JOIN pack ON view_packed.parent_sn=pack.child_sn
WHERE view_packed.model='tray')

SELECT COUNT(*)::INT FROM tray";

                case Main2.Model.pack:
                    return $@"WITH pack AS(
SELECT child_sn
FROM SHIP.view_packed
WHERE model='pack'
AND parent_sn='{sn}')

,tray AS(
SELECT view_packed.child_sn,view_packed.p_date
FROM SHIP.view_packed
JOIN pack ON view_packed.parent_sn=pack.child_sn
WHERE view_packed.model='tray')

SELECT COUNT(*)::INT FROM tray";

                case Main2.Model.tray:
                    return $@"WITH tray AS(
SELECT child_sn
FROM SHIP.view_packed
WHERE model='tray'
AND parent_sn='{sn}')

SELECT COUNT(*)::INT FROM tray";

                default:
                    return $"'{model}' model is false";
            }
        }
    }
}
