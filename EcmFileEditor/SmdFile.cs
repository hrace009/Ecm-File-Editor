using LBLIBRARY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcmFileEditor
{
    public class SmdFile
    {
        public long Header;
        public int Version;
        public int unk1;
        public int ActionsAmount;
        public int unk2;
        public int unk3;
        public int unk4;
        public int unk5;
        public int unk6;
        public int unk7;
        public int unk8;
        public int unk9;
        public int unk10;
        public int unk11;
        public int unk12;
        public int unk13;
        public int unk14;
        public int unk15;
        public int unk16;
        public int unk17;
        public int unk18;
        public string Bone;
        public string Ski;
        public string Phy;
        public string StckDirectoryName;
        public List<SmdAction> Actions = new List<SmdAction>();

        public SmdFile(string file)
        {
            BinaryReader br = new BinaryReader(File.Open(file, FileMode.Open));
            Header = br.ReadInt64();
            Version = br.ReadInt32();
            unk1 = br.ReadInt32();
            ActionsAmount = br.ReadInt32();
            unk2 = br.ReadInt32();
            unk3 = br.ReadInt32();
            unk4 = br.ReadInt32();
            unk5 = br.ReadInt32();
            unk6 = br.ReadInt32();
            unk7 = br.ReadInt32();
            unk8 = br.ReadInt32();
            unk9 = br.ReadInt32();
            unk10 = br.ReadInt32();
            unk11 = br.ReadInt32();
            unk12 = br.ReadInt32();
            unk13 = br.ReadInt32();
            unk14 = br.ReadInt32();
            unk15 = br.ReadInt32();
            unk16 = br.ReadInt32();
            unk17 = br.ReadInt32();
            unk18 = br.ReadInt32();
            Bone = br.ReadBytes(br.ReadInt32()).Decode(Encoding.GetEncoding(936));
            if (unk1 == 1)
            {
                Ski = br.ReadBytes(br.ReadInt32()).Decode(Encoding.GetEncoding(936));
            }
            if (Version > 4)
            {
                Phy = br.ReadBytes(br.ReadInt32()).Decode(Encoding.GetEncoding(936));
            }
            if (unk1 == 2)
            {
                Ski = br.ReadBytes(br.ReadInt32()).Decode(Encoding.GetEncoding(936));
            }
            if (Version > 6)
            {
                StckDirectoryName = br.ReadBytes(br.ReadInt32()).Decode(Encoding.GetEncoding(936));
            }
            for (int i = 0; i < ActionsAmount; i++)
            {
                Actions.Add(new SmdAction(br, Version));
            }
            br.Close();
        }
    }
    public class SmdAction
    {
        public string ActionName = "";
        public float unk1;
        public float unk2;
        public int Amount;
        public int unk3;
        public List<Unknown> Unknowns = new List<Unknown>();
        public int unk4;
        public int unk5;
        public string ActionFileName = "";
        public SmdAction(BinaryReader br, int Version)
        {
            ActionName = br.ReadBytes(br.ReadInt32()).Decode(Encoding.GetEncoding(936));
            if (Version == 5)
            {
                unk5 = br.ReadInt32();
                Amount = br.ReadInt32();
                unk3 = br.ReadInt32();
                for (int i = 0; i < Amount; i++)
                {
                    Unknowns.Add(new Unknown(br));

                }
            }
            if (Version > 5)
            {
                unk1 = br.ReadSingle();
                unk2 = br.ReadSingle();
            }
            if (Version > 8)
            {
                unk4 = br.ReadInt32();
            }
            if (Version > 6)
            {
                ActionFileName = br.ReadBytes(br.ReadInt32()).Decode(Encoding.GetEncoding(936));
            }

        }
    }
    public class Unknown
    {
        public int u1;
        public float u2;
        public float u3;
        public int u4;
        public float u5;
        public Unknown(BinaryReader br)
        {
            u1 = br.ReadInt32();
            u2 = br.ReadSingle();
            u3 = br.ReadSingle();
            u4 = br.ReadInt32();
            u5 = br.ReadSingle();
        }
    }
}
