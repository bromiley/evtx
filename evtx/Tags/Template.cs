﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace evtx.Tags
{
public    class Template
    {
   

        public Template(int templateId, int templateOffset, Guid guid, byte[] payload, int nextTemplateOffset, long templateAbsoluteOffset)
        {
            var l = LogManager.GetLogger("Template");

            TemplateId = templateId;
            TemplateOffset = templateOffset;

            Size = payload.Length;
            TemplateGuid = guid;
            NextTemplateOffset = nextTemplateOffset;
            TemplateAbsoluteOffset = templateAbsoluteOffset;

            Nodes = new List<IBinXml>();

            var index = 0;

            //TODO
            //process payload here at some point
            
        }

        public List<IBinXml> Nodes { get; set; }
        
        public int Size { get; }
        public string AsXml()
        {
            throw new NotImplementedException();
        }

        public int TemplateOffset { get; }
        public int NextTemplateOffset { get; }
        public int TemplateId { get; }
        public long TemplateAbsoluteOffset { get; }
        public Guid TemplateGuid { get; }

        public override string ToString()
        {
            return $"Absolute offset: 0x{TemplateAbsoluteOffset:X8} Template Offset 0x{TemplateOffset:X8} Guid: {TemplateGuid} Size: 0x{Size:X4}";
        }
    }
}