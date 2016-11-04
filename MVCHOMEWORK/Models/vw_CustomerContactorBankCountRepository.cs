using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVCHOMEWORK.Models
{   
	public  class vw_CustomerContactorBankCountRepository : EFRepository<vw_CustomerContactorBankCount>, Ivw_CustomerContactorBankCountRepository
	{

	}

	public  interface Ivw_CustomerContactorBankCountRepository : IRepository<vw_CustomerContactorBankCount>
	{

	}
}