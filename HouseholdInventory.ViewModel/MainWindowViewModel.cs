using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseholdInventory.Data;
using HouseholdInventory.Application;

namespace HouseholdInventory.ViewModel
{
	public class MainWindowViewModel
	{
	    private IUIDataProvider _dataProvider;
        private IList<Asset> _assets;

	    public MainWindowViewModel(IUIDataProvider dataProvider)
	    {
	        _dataProvider = dataProvider;
	    }
        public IList<Asset> Assets
        {
            get
            {
                if (_assets == null)
                {
                    _dataProvider.GetAssets();
                }
                return _assets;
            }
        }

	    
	}
}
