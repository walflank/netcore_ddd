﻿using CRUD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.Interfaces
{
    public interface IPistaService
    {
        List<PistaViewModel> AllPistas();
    }
}
