using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace SharpMTKClient.Class.Protocol.xml
{
    public class SlaKey
    {
        public string vendor { get; set; }
        public List<int> da_codes { get; set; }
        public string name { get; set; }
        public string d { get; set; }
        public string n { get; set; }
        public string e { get; set; }
        public BigInteger d_da { get; set; }
        public BigInteger n_da { get; set; }
        public BigInteger e_da { get; set; }
        public AsymmetricKeyParameter Key { get; set; }

        public SlaKey(string vendor, List<int> daCodes, string name, string d, string n, string e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static List<SlaKey> da_sla_keys = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static List<SlaKey> brom_sla_keys = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
    }

    public class SlaSignatureHandler
    {
        public static byte[] customized_sign(BigInteger n, BigInteger e, byte[] msg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] generate_brom_sla_challenge(byte[] data, string d, string e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] generate_da_sla_signature(byte[] data, AsymmetricKeyParameter key)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}