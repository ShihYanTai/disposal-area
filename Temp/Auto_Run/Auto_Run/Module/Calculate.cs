using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Run.Module
{
    internal class Calculate
    {
        public async Task<Dictionary<DateTime, Dictionary<string, DataIO.Minu60>>> Minu60Data(ConcurrentDictionary<DateTime, Dictionary<string, DataIO.Min5Data>> min5Data)
        {
            try
            {
                var t = await Task.Run(() =>
                {
                    var Month_Group = from m in min5Data
                                      group m by m.Key.Month into mtemp
                                      orderby mtemp.Key descending
                                      select mtemp;

                    Dictionary<DateTime, Dictionary<string, DataIO.Minu60>> Time_Min60Data = new Dictionary<DateTime, Dictionary<string, DataIO.Minu60>>();
                    foreach (var Month_Group_Each in Month_Group)
                    {
                        var d_Group_Each = (from d in Month_Group_Each
                                            group d by d.Key.Date into dtemp
                                            select dtemp);

                        foreach (var h_Group_Each in d_Group_Each)
                        {
                            var m_Group_Eachs = (from h in h_Group_Each
                                                 group h by h.Key.Hour into mtemp
                                                 select mtemp);

                            foreach (var m_Group_Each in m_Group_Eachs)
                            {
                                Dictionary<string, DataIO.Minu60> Min60Data = new Dictionary<string, DataIO.Minu60>();
                                foreach (string Items_Index in min5Data.Values.First().Keys)
                                {
                                    float? Min60Value = (from s in m_Group_Each
                                                         where s.Key.Year != 0001
                                                         select s).ToArray().Average(s => s.Value[Items_Index].Rd5min_Value);

                                    string Min60_Status = (from Tmp_Start in m_Group_Each
                                                           where Tmp_Start.Key.Year != 0001
                                                           select Tmp_Start.Value[Items_Index].Rd5min_Status
                                                       ).ToArray().First();

                                    DataIO.Minu60 calculate60 = new DataIO.Minu60
                                    {
                                        Min60_Value = Min60Value,
                                        Min60_Status = Min60_Status
                                    };
                                    Min60Data.Add(Items_Index, calculate60);
                                }
                                Time_Min60Data.Add(m_Group_Each.Min(X => X.Key), Min60Data);
                            }
                        }
                    }
                    return Time_Min60Data;
                });

                return t;
            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Failed at Calculate"));
                throw;
            }
        }
    }
}
