using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys.Dashboard
{
    public class RegistersTendencyEntity
    {
        public DateTime CreateDate
        {
            get;
            set;
        } 

        public int Hour 
        {
            get;
            set;
        }

        public int DataValue
        {
            get;
            set;
        }
    }
    public class RegistersIncreaseEntity
    {
        public DateTime CreateDate
        {
            get;
            set;
        }

        public int Hour
        {
            get;
            set;
        }

        public string MemberLevel
        {
            get;
            set;
        }

        public int DataValue
        {
            get;
            set;
        }
    }

    public class VNoHeadDistributionEntity
    {
        public string VNoHead
        {
            get;
            set;
        }

        public int DataValue
        {
            get;
            set;
        }
    }

    public class VNoHeadTendencyEntity
    {
        public string VNoHead
        {
            get;
            set;
        }

        public int DataValue
        {
            get;
            set;
        }

        public int Hour
        {
            get;
            set;
        }

        public DateTime CreateDate
        {
            get;
            set;
        }
    }
}
