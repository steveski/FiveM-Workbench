﻿namespace FiveM_Workbench.ClothingOrganiser.ViewModels
{
    using System.Collections.ObjectModel;

    public interface IDropTargetItemViewModel<TItemVm>
    {
        public bool CanAcceptChildren { get; set; }
        public ObservableCollection<TItemVm> Children { get; set; }

    }
}
