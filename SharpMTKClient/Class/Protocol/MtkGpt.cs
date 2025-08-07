using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class MtkGpt : IEquatable<MtkGpt>
    {
        protected virtual Type EqualityContract
        {
            get
            {
                return typeof(MtkGpt);
            }
        }

        public string Signature { get; set; }
        public int Revision { get; set; }
        public int HeaderSize { get; set; }
        public int Crc32 { get; set; }
        public int Reserved { get; set; }
        public long CurrentLba { get; set; }
        public long BackupLba { get; set; }
        public long FirstUsableLba { get; set; }
        public long LastUsableLba { get; set; }
        public Guid Guid { get; set; }
        public long PartitionEntryStartLba { get; set; }
        public int PartitionEntriesCount { get; set; }
        public int PartitionEntrySize { get; set; }
        public int SectorSize { get; set; }
        public MtkGptPartition[] Partitions { get; set; }

        public MtkGpt()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public override string ToString()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected virtual bool PrintMembers(StringBuilder builder)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static bool operator !=(MtkGpt left, MtkGpt right)
        {
            return !(left == right);
        }

        public static bool operator ==(MtkGpt left, MtkGpt right)
        {
            if ((object)left != right)
            {
                return left?.Equals(right) ?? false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public virtual bool Equals(MtkGpt other)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public virtual MtkGpt Clone()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected MtkGpt(MtkGpt original)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}