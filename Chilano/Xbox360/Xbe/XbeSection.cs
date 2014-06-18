﻿namespace Chilano.Xbox360.Xbe
{
    using IO;
    using System.IO;

    public class XbeSection
    {
        public byte[] Data;
        public XbeSectionHeader Header;
        public string Name;

        public XbeSection()
        {
        }

        public XbeSection(CBinaryReader br)
        {
            Header = new XbeSectionHeader(br);
            Name = "";
        }

        public void Read(CBinaryReader br, uint BaseAddress)
        {
            br.Seek((long) (Header.SectionNameAddress - BaseAddress), SeekOrigin.Begin);
            while (br.PeekChar() != 0)
            {
                Name = Name + br.ReadChar();
            }
            br.Seek((long) Header.RawAddress, SeekOrigin.Begin);
            Data = br.ReadBytes((int) Header.RawSize);
        }
    }
}

