using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class MtkGptPartition : IEquatable<MtkGptPartition>
    {
        protected virtual Type EqualityContract
        {
            [CompilerGenerated]
            get
            {
                return typeof(MtkGptPartition);
            }
        }

        public int Type { get; set; }
        public Guid Id { get; set; }
        public long FirstLba { get; set; }
        public long LastLba { get; set; }
        public long Flags { get; set; }
        public string Name { get; set; }
        public long SectorCount => LastLba - FirstLba + 1L;

        public MtkGptPartition()
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

        public static bool operator !=(MtkGptPartition left, MtkGptPartition right)
        {
            return !(left == right);
        }

        public static bool operator ==(MtkGptPartition left, MtkGptPartition right)
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

        public virtual bool Equals(MtkGptPartition other)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public virtual MtkGptPartition _003CClone_003E_0024()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected MtkGptPartition(MtkGptPartition original)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}