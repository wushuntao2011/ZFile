﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZFile.Core.Model.File;

namespace ZFile.Service.DtoModel
{
    public class FT_FolderDto : FT_Folder
    {
        public string AuthUser { get; set; }
    }

    public class FT_FileDto : FT_File
    {
        public string AuthUser { get; set; }
    }

    public class FT_FileDtoTwo : FT_File
    {
        public string FolderType { get; set; }
    }

    public class DelFile
    {
        public int Id { get; set; }


        public int Type { get; set; }
    }


    public class PasteitemsDto
    {
       
        public int Pid { get; set; }

        public IEnumerable<PasteitemsChild>  Child { get; set; }

    }
    public class PasteitemsChild
    {
        public int itemId { get; set; }

        public int ItemType { get; set; }
    }

}
