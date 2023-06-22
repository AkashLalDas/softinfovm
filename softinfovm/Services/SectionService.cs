using softinfovm.Connections;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace softinfovm.Services
{
    public class SectionService
    {
        public dynamic getSubsectionCode(string[] payload)
        {
            var dbConnection = new Dbconnection();
            var _query = "select (sm.sectionName + '#' + sd.subsectionName) as Name, sd.subsectionCode from SectionM sm join sectionD sd on sm.sectionCode = sd.sectionCode where (sm.sectionName + '#' + sd.subsectionName) in ('" + string.Join("','", payload.ToList()) + "')";
            var _data = dbConnection.Database.SqlQuery<dynamic>(_query).ToList();

            var _model = from sectionM in dbConnection.sectionMModels
                         join sectionD in dbConnection.SectionDModels
                         on sectionM.sectionCode equals sectionD.sectionCode
                         where payload.Contains((sectionM.sectionName + "#" + sectionD.subsectionName))
                         select new
                         {
                             Name = (sectionM.sectionName + "#" + sectionD.subsectionName),
                             SubsectionCode = sectionD.subsectionCode
                         };

            //return _data;
            return _model.ToList();
        }
    }
}