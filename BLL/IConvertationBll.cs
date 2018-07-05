using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public interface IConvertationBll
    {
        Material ConvertMaterialsToDB(BllMaterials tmpMaterial);
        BllMaterials ConvertBllMaterials(Material tmpMaterial);
        BllInfo ConvertToBllInfo(Info info);
        BllStaff ConvertStaffToBll(Staff dTODallStaff);
        BllStaff ConvertStaffToBllpartial(Staff dTODallStaff);
        Staff ConvertStaffToDTO(BllStaff bllStaff);
        BllWorkPosition ConvertPositionToBll(WorkPosition WorkPosition);
        WriteOffMaterial ConvertWriteOffToBD(WriteOffMaterialBll writeOffMaterialBll);
        WorkPosition ConvertPositionToDTO(BllWorkPosition bllWorkPosition);
        BllServices ConvertServicesToBll(Service dTODalService);
        Service ConvertServicesToDTO(BllServices bllServices);

    }
}
