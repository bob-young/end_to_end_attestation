﻿//  Copyright (C) Intel Corporation, 2007 - 2009 All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaSpRef
{
    public static class Constants
    {
        public const string DefaultApi = "DefaultApi";
        public const string RouteTemplate = "api/{controller}/{action}/{id}";
        public const bool SUCCESS = true;
        public const bool FAIL = true;

        public const int CLIENT_TIMEOUT = 15;
        public const int TICKS_PER_SECOND = 100;
        public const string zeroNonceSz = "00000000000000000000000000000000";

        public const string Respond = "RESPOND";
        public const string Request = "REQUEST";
        public const string CurrentUserCertStore = "MY";

        public const int Base16 = 16;
        public const int CharsPerByte = 2;

        public const int retryCount = 3;
        public const int EPIDpseudonymLen = 128;
        public const int M4DurationLoc = 1;
        public const int M4DurationLen = 3;
        public const int M4MaxDuration = 0xFFFFFF;


        private const string iasReportSig = "X-IASReport-Signature";
        public static string IASReportSig { get { return iasReportSig; } }

        private const string attestationReport = "attestation/sgx/v1/report";
        public static string AttestationReportUri { get { return attestationReport; } }

        private const string sigRLUri = "attestation/sgx/v1/sigrl/";
        public static string SigRLUri { get { return sigRLUri; } }

        private const int aesGCMTagLen = 16;
        public static int AESGCMTagLen
        {
            get { return aesGCMTagLen; }
        }

        private const int ivLen = 12;
        public static int IVLen
        {
            get { return ivLen; }
        }

        private const int randomPayload = 32;
        public static int RandomPayload
        {
            get { return randomPayload; }
        }

        private const int raStatusCodeLen = 4;
        public static int RAStatusCodeLen
        {
            get { return raStatusCodeLen; }
        }

        private const int dhKeyLen = 256;
        public static int DHKeyLen
        {
            get { return dhKeyLen; }
        }

        private const int sharedKeylen = 32;
        public static int SharedKeylen
        {
            get { return sharedKeylen; }
        }

        private const int gaGbLen = 32;
        public static int GaGbLen
        {
            get { return gaGbLen; }
        }

        private const int pseManifestLen = 256;
        public static int PSEManifestLen
        {
            get { return pseManifestLen; }
        }

        public const string ProvisionStr = "Provision";
        public const string msg0Str = "Msg0";
        public const string msg1Str = "Msg1";
        public const string msg3Str = "Msg3";

        // For keeping track of client transaction sequence state
        public enum SequenceState
        {
            None = 0,
            Provision,
            Challenge,
            Msg0,
            Msg1,
            Msg2,
            Msg3,
            Msg4
        }






        //Initialize various byte arrays for later message construction
        //NOTE: some sample elements for testing were obtained from pre-computed messages.

        // Byte arrays for error path testing, debug, and default message construction
        public static readonly byte[] snZ12 = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] sn1 = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static readonly byte[] sn2 = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static readonly byte[] sn3 = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static readonly byte[] sampleGid = { 0x00, 0x00, 0x00, 0x37 }; //00000037 working value for success path testing
        public static readonly byte[] sampleGaXba = { 0x4a, 0xdb, 0xda, 0x83, 0x72, 0x33, 0xfc, 0x62, 0x2c, 0xef, 0x79, 0xa, 0x6c, 0x9e, 0xe7, 0xe3, 
                                             0x8a, 0x6, 0x4a, 0xdf, 0x22, 0xc5, 0x64, 0xd2, 0x12, 0x19, 0xcf, 0x55, 0x2e, 0x5, 0xd7, 0x9c };
        public static readonly byte[] sampleGaYba = { 0xbc, 0xa6, 0x3, 0x9, 0xbf, 0x8a, 0x43, 0x7f, 0xb4, 0xbf, 0xfa, 0x6b, 0x93, 0x1a, 0xeb, 0x38,
                                             0x58, 0x66, 0x32, 0xa9, 0x0, 0x7d, 0x76, 0xe4, 0xc5, 0x1f, 0x3a, 0xbd, 0xa4, 0x24, 0x77, 0x39 };
        public static readonly byte[] sampleGbXba = { 0x6a, 0x83, 0xdc, 0x84, 0xd4, 0x4c, 0x8a, 0xbb, 0x5e, 0x42, 0xaf, 0xee, 0x8d, 0xe9, 0xf4, 0x57,
                                             0x71, 0xfd, 0x73, 0x66, 0xd7, 0xfa, 0xad, 0xfa, 0xf2, 0x17, 0x14, 0xdd, 0x5a, 0xb9, 0x9e, 0x97 };
        public static readonly byte[] sampleGbYba = { 0x79, 0xa7, 0x38, 0x72, 0xf2, 0xb8, 0xd6, 0xbe, 0x18, 0x91, 0x7f, 0xf7, 0xb5, 0xd3, 0xe5, 0x64, 
                                             0x9b, 0x12, 0x18, 0xaf, 0x39, 0x29, 0x6c, 0x24, 0x19, 0x38, 0x29, 0xb, 0xc6, 0xac, 0xc, 0x62 };
        public static readonly byte[] gaM1blob = { 0x45, 0x43, 0x4B, 0x31, 0x20, 0x00, 0x00, 0x00, 
        0x72, 0xc0, 0xec, 0x84, 0x17, 0xc5, 0xf7, 0xe9, 0x60, 0xf2, 0x3d, 0xba, 0xe7, 0x46, 0x5d, 0x03, 
        0x0d, 0x28, 0xb0, 0xf4, 0x76, 0x7e, 0xd3, 0x61, 0x79, 0xc1, 0x69, 0x7c, 0x89, 0x39, 0x3d, 0x2b, 
        0xab, 0x06, 0xdd, 0x32, 0x3f, 0x37, 0xda, 0x3b, 0x8c, 0x90, 0xba, 0x40, 0xdc, 0xe9, 0x7e, 0x1a, 
        0xe4, 0x48, 0x7e, 0x9c, 0xc1, 0x76, 0x2b, 0x2e, 0x5e, 0xda, 0xb3, 0xe5, 0x67, 0x30, 0xe7, 0x14 };
        public static readonly byte[] spIdba = { 0x2b, 0xda, 0x6f, 0xf6, 0xfb, 0xa2, 0x90, 0x52, 0x96, 0xbc, 0xb0, 0x45, 0x0d, 0x4e, 0x0a, 0x1e };
        public static readonly byte[] sigSpXba = { 0x6a, 0x83, 0xdc, 0x84, 0xd4, 0x4c, 0x8a, 0xbb, 0x5e, 0x42, 0xaf, 0xee, 0x8d, 0xe9, 0xf4, 0x57,
                                          0x71, 0xfd, 0x73, 0x66, 0xd7, 0xfa, 0xad, 0xfa, 0xf2, 0x17, 0x14, 0xdd, 0x5a, 0xb9, 0x9e, 0x97 };
        public static readonly byte[] sigSpYba = { 0x7b, 0x74, 0xa0, 0x35, 0x35, 0xc3, 0xcc, 0x32, 0xf9, 0x89, 0xf, 0xa3, 0x3b, 0x14, 0xa0, 0x65, 
                                          0xae, 0x70, 0x1f, 0x4d, 0xbe, 0x2d, 0xef, 0x92, 0x8d, 0xe3, 0x25, 0xa0, 0x54, 0xa1, 0x95, 0x43 };
        public static readonly byte[] sltype = { 0x00, 0x00 };
        public static readonly byte[] linkableBa = { 0x01, 0x00 };
        public static readonly byte[] kdfId = { 0x01, 0x00 }; /* key derivation function id in little endian. 
                                             0x0001 for AES-CMAC Entropy Extraction and Key Derivation */
        public static readonly string SMK = "SMK";
        public static readonly string SK = "SK";
        public static readonly string MK = "MK";
        public static readonly string VK = "VK";

        public static readonly byte[] sampleCmacsmk = { 0x29, 0xd6, 0x4a, 0x88, 0x9e, 0x9e, 0xb6, 0x9, 0x77, 0xd5, 0x78, 0x81, 0x4e, 0xc3, 0xf7, 0xb3 };
        public static readonly byte[] sampleM3secProp = { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
        0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
        0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
        0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
        0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x1, 0x0, 0x1, 0x14, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 
        0x65, 0x20, 0x58, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 
        0x5, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
        0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x7, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
        0x7, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xa0, 0xeb, 0x9c, 0x45, 0x60, 0x2c, 0x37, 0xaa, 0x59, 0x4e, 0x3d, 0x39, 0x50, 0xd2, 0xf5, 0x70, 0xbb, 
        0x0, 0xa6, 0x9, 0x7d, 0xf9, 0xed, 0x8f, 0x13, 0x1c, 0x58, 0x89, 0x13, 0x79, 0x8d, 0x57, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
        public static readonly byte[] sampleQuote = { 0x01, 0x00, 0x00, 0x00, 0x96, 0x03, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x2B, 0xDA, 0x6F, 0xF6, 0xFB, 0xA2, 0x90, 0x52, 0x96, 0xBC, 0xB0, 0x45, 0x0D, 0x4E, 0x0A, 0x1E, 0x9F, 0xE7, 0x26, 0xC6, 0x34, 0x68, 0x3E, 0x0F, 
        0xA3, 0x5A, 0x64, 0xA0, 0x13, 0xB7, 0x6D, 0xAF, 0x02, 0x02, 0x02, 0x02, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0xAC, 0x9F, 0x04, 0x39, 0x33, 0x15, 0x36, 0x1E, 0xB3, 0x13, 0x2C, 0x5C, 0xE4, 0x6B, 0xC1, 0x08, 0xE2, 0x69, 0x5E, 0x77, 0xC6, 0x20, 0x17, 0xAF, 
        0x1F, 0x2F, 0x4B, 0xA4, 0x71, 0x43, 0xF7, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xDE, 0xCD, 0x29, 0x14, 0x7F, 0xE1, 0x13, 0x17, 
        0x38, 0x65, 0x8C, 0xE9, 0xE4, 0xB8, 0x27, 0xDB, 0x00, 0x26, 0x90, 0x19, 0x6A, 0x81, 0x03, 0x12, 0x30, 0xD5, 0x73, 0x9C, 0x3A, 0x9E, 0x59, 0x86, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA8, 0x02, 0x00, 0x00, 0x18, 0xC1, 0xFE, 0x62, 0xA4, 0x96, 0xC8, 0xE3, 0x9E, 0xC8, 0xEA, 0x41, 
        0x08, 0x58, 0x18, 0x2C, 0xF6, 0x95, 0x9F, 0x86, 0xFA, 0xE5, 0xE8, 0xDB, 0xF4, 0x38, 0x15, 0xDA, 0x14, 0xE0, 0xF1, 0x9B, 0x8C, 0x18, 0xFB, 0xB9, 
        0xF4, 0x5A, 0x1A, 0xDC, 0x5B, 0xB1, 0x82, 0x93, 0x4C, 0x7B, 0x78, 0x14, 0x88, 0x49, 0x42, 0x08, 0x60, 0x64, 0xC7, 0x1E, 0x7F, 0x93, 0xFE, 0x31, 
        0x28, 0x69, 0xBB, 0x9C, 0x94, 0x62, 0x78, 0xC9, 0x43, 0x73, 0x54, 0xDC, 0x2D, 0xAC, 0xF0, 0x64, 0x50, 0x1F, 0x4E, 0xEA, 0xCF, 0x2C, 0x64, 0x79, 
        0x4C, 0x1A, 0xE8, 0xB9, 0x2F, 0x74, 0x84, 0xB5, 0xA1, 0x80, 0xD7, 0x9A, 0xA8, 0x90, 0x7B, 0xD1, 0x07, 0xF6, 0x17, 0xE7, 0x38, 0x2B, 0xA5, 0x5D, 
        0x8D, 0xE4, 0xB9, 0x75, 0x86, 0x91, 0xC5, 0xCD, 0xCE, 0x64, 0xA5, 0xD6, 0xCF, 0x0D, 0xBD, 0x69, 0x8D, 0x71, 0xAB, 0xF5, 0x76, 0x2A, 0xA3, 0x65, 
        0xAC, 0x57, 0x5B, 0x33, 0x98, 0x98, 0xF3, 0xAF, 0x3F, 0x8B, 0x93, 0x42, 0x96, 0x5F, 0x97, 0xC8, 0x71, 0xE2, 0xD4, 0xC2, 0x0D, 0xF6, 0x1C, 0x17, 
        0xC1, 0xF9, 0x63, 0xE2, 0x76, 0x81, 0xA7, 0x78, 0x08, 0x48, 0x36, 0x27, 0xE4, 0xEE, 0xDC, 0x37, 0xB6, 0xB9, 0x07, 0x0F, 0x90, 0xC5, 0x7B, 0x40, 
        0xB5, 0x20, 0x33, 0xAE, 0x6C, 0x3A, 0x95, 0x5D, 0x35, 0x4A, 0x9E, 0xCD, 0x1E, 0xCB, 0x03, 0xB9, 0x61, 0x1B, 0xA9, 0x6A, 0x85, 0xFB, 0xAF, 0xCF, 
        0x62, 0x99, 0x47, 0xDC, 0xC0, 0x16, 0xFF, 0xCB, 0x0B, 0x1B, 0x02, 0xAA, 0x6E, 0x62, 0x78, 0xFC, 0x59, 0x41, 0x94, 0x5B, 0x62, 0x70, 0xB8, 0x1A, 
        0xAC, 0x5A, 0x95, 0xF3, 0x83, 0x1E, 0xB2, 0xF7, 0x86, 0xBB, 0x40, 0x66, 0x61, 0x06, 0x3C, 0x2D, 0x1B, 0x2B, 0x6B, 0x58, 0x60, 0x03, 0xB9, 0x2E, 
        0x35, 0x5F, 0xB8, 0xFE, 0x8C, 0x9A, 0x60, 0xB4, 0xA2, 0xE3, 0xD6, 0x2D, 0x26, 0x66, 0x50, 0x86, 0xA0, 0xAD, 0x33, 0xBD, 0xC1, 0xA7, 0xF8, 0xE1, 
        0x13, 0x64, 0xBA, 0x74, 0x94, 0xBE, 0x0B, 0x1B, 0xA8, 0xA3, 0x8C, 0xA6, 0x7D, 0x02, 0x69, 0xC2, 0x90, 0xC6, 0x97, 0x4F, 0x83, 0xB4, 0xE5, 0xFB, 
        0x68, 0x01, 0x00, 0x00, 0x79, 0x23, 0xDA, 0x3B, 0x03, 0x9D, 0x80, 0xFA, 0x7D, 0xF7, 0x04, 0xE5, 0x86, 0x6C, 0x8C, 0x7D, 0x37, 0x31, 0xF9, 0x4C, 
        0x1D, 0x19, 0x03, 0x92, 0x5A, 0x4C, 0xBD, 0x3A, 0x05, 0x08, 0x90, 0xCE, 0xC0, 0xF8, 0x41, 0xF5, 0x9C, 0x3B, 0x65, 0x36, 0xA8, 0xA1, 0x26, 0x67, 
        0x7F, 0x80, 0x94, 0xB2, 0x37, 0x08, 0x1A, 0x78, 0x9E, 0xBA, 0xCD, 0xE4, 0xE1, 0x5A, 0x51, 0xCE, 0x87, 0xB1, 0xB9, 0xDC, 0x16, 0xCB, 0x2D, 0x4B, 
        0x9E, 0x9C, 0x50, 0x33, 0x1F, 0x8E, 0x76, 0x0E, 0xB9, 0x4B, 0x87, 0xFC, 0x82, 0xDE, 0x83, 0xD8, 0x86, 0x11, 0x18, 0x53, 0xA1, 0x3F, 0xDE, 0xE4, 
        0x65, 0x33, 0x59, 0x42, 0x38, 0x0E, 0xBB, 0x6A, 0x8E, 0xE9, 0xDC, 0x44, 0x47, 0x9B, 0x4A, 0xB0, 0xE4, 0x62, 0x7F, 0xD9, 0xEB, 0xAC, 0x1D, 0x14, 
        0xA7, 0xC1, 0xC7, 0xAA, 0x4F, 0x59, 0x1D, 0x61, 0xC9, 0x82, 0x33, 0x8B, 0xC2, 0x1C, 0x41, 0xE1, 0x99, 0x4B, 0x88, 0x7F, 0xD8, 0xA3, 0xA1, 0x80, 
        0xCC, 0x94, 0xAB, 0x5D, 0xDA, 0x26, 0xD6, 0x86, 0x51, 0x68, 0x3A, 0x1A, 0xBB, 0x80, 0x1E, 0xEB, 0xC2, 0x10, 0x29, 0x68, 0xF8, 0x3C, 0x0B, 0x16, 
        0x6A, 0xC7, 0xA6, 0xDA, 0x6C, 0x00, 0xC1, 0x76, 0xC3, 0x0D, 0x0E, 0x87, 0xF7, 0x2D, 0x7A, 0x32, 0xCE, 0x69, 0x1B, 0x69, 0x34, 0x36, 0x4F, 0x81, 
        0x46, 0x2D, 0xC3, 0x3B, 0x0F, 0xC7, 0xA2, 0xE4, 0xDA, 0xFD, 0xF9, 0x9B, 0x27, 0x85, 0xA7, 0x43, 0xDB, 0xA4, 0x1E, 0x20, 0xE8, 0x27, 0x00, 0x16, 
        0xD8, 0x1C, 0x5A, 0xF7, 0xE2, 0x6D, 0xD4, 0xED, 0x36, 0xE5, 0xC3, 0x4F, 0xEF, 0xD6, 0x42, 0x85, 0x65, 0xB9, 0xA4, 0xB4, 0x07, 0x9D, 0xD1, 0xD1, 
        0x76, 0x4B, 0x98, 0x43, 0x25, 0xC9, 0x9A, 0x01, 0x6E, 0x69, 0xE5, 0xB0, 0x37, 0xD7, 0xDB, 0xC7, 0xC9, 0xD5, 0x86, 0x35, 0x0D, 0x15, 0xB1, 0xE4, 
        0xF9, 0xC6, 0xA8, 0x05, 0xAF, 0xD3, 0x04, 0xFB, 0xCE, 0xD8, 0x1D, 0x95, 0xCF, 0x36, 0x1F, 0xBC, 0x53, 0x00, 0xAC, 0x50, 0x08, 0x7A, 0xA5, 0x08, 
        0x26, 0x57, 0x96, 0xE0, 0xF6, 0x08, 0x4D, 0xA4, 0xA4, 0x45, 0x7E, 0xA9, 0x2E, 0x9B, 0x51, 0xB6, 0xC1, 0x20, 0xC4, 0x96, 0x38, 0xB3, 0x4A, 0x0A, 
        0x3C, 0x60, 0x04, 0x4E, 0x54, 0x35, 0x50, 0x3A, 0x81, 0xA7, 0xC8, 0x96, 0xC2, 0xAF, 0x7D, 0xB3, 0x89, 0x26, 0xC2, 0x43, 0xE3, 0x8B, 0x42, 0x21, 
        0xED, 0x47, 0x83, 0x84, 0x2E, 0x55, 0xED, 0xC8, 0xDD, 0x68, 0xF9, 0x91, 0xCC, 0x6B, 0x98, 0x95, 0x14, 0xCE, 0xB0, 0x5B, 0xB0, 0x79, 0x8A, 0x6C, 
        0x8E, 0xF0, 0xB3, 0xB6, 0x5A, 0x3D, 0x07, 0x9A, 0x17, 0x85, 0x1F, 0x69, 0xD4, 0xCE, 0xC0, 0x04, 0x79, 0x71, 0x48, 0x8E };
        //
        
        
        // The SP's ECDSA signing key blob, where the first 8 Bytes are the Microsoft "Magic" values that 
        // describe the NIST-P256 curve, and indicate whether or not the key is private.  This example key is
        // used by the SP RA server code to sign elements of Message 2, but would not necessarily be
        // hardcoded in the server application.
        public static readonly byte[] spPrivKeyBlob = { 0x45, 0x43, 0x53, 0x32, 0x20, 0x00, 0x00, 0x00,
        0x39, 0x16, 0xB0, 0x69, 0xB2, 0xBB, 0x0F, 0x92, 0xC4, 0x10, 0x27, 0x30, 0x9E, 0x45, 0x61, 0x93,
        0xB1, 0x67, 0x4F, 0xFB, 0x3E, 0xBC, 0x1F, 0xC5, 0xAE, 0x9F, 0x1A, 0x59, 0x45, 0x9F, 0x8C, 0xC0,
        0x4F, 0x96, 0x00, 0x30, 0x6E, 0x6C, 0x1F, 0x23, 0xF1, 0x5A, 0x2B, 0x1C, 0xC8, 0x32, 0xEB, 0xB8,
        0xDC, 0x6A, 0x1A, 0xA9, 0xE0, 0xCA, 0x35, 0x2A, 0x72, 0x46, 0x52, 0x2B, 0x24, 0x6B, 0x98, 0x5D,
        0x40, 0x8A, 0x06, 0x1A, 0xE6, 0x81, 0x3A, 0x7B, 0xAC, 0x4E, 0x34, 0xAA, 0x4D, 0x61, 0x3C, 0x86,
        0xF3, 0xDD, 0x9C, 0x48, 0x82, 0xA8, 0x68, 0x57, 0xFC, 0xB3, 0x9D, 0xF9, 0x81, 0xB6, 0x56, 0x2D};

        // For reference, the corresponding SP public key for the SGX Client side is included here. 
        // The ECDSA public key may be hard coded in the enclave code, but the public key is not used directly 
        // by the SP RA server code.  
        // NOTE: the "Magic" values that would form an "EccPublicBlob" are not included.
        public static readonly byte[] spPublicKey = { 0x39, 0x16, 0xB0, 0x69, 0xB2, 0xBB, 0x0F, 0x92, 0xC4, 0x10, 0x27, 0x30, 0x9E,
         0x45, 0x61, 0x93, 0xB1, 0x67, 0x4F, 0xFB, 0x3E, 0xBC, 0x1F, 0xC5, 0xAE, 0x9F, 0x1A, 0x59, 0x45, 0x9F, 0x8C, 0xC0,
         0x4F, 0x96, 0x00, 0x30, 0x6E, 0x6C, 0x1F, 0x23, 0xF1, 0x5A, 0x2B, 0x1C, 0xC8, 0x32, 0xEB, 0xB8, 0xDC, 0x6A, 0x1A,
         0xA9, 0xE0, 0xCA, 0x35, 0x2A, 0x72, 0x46, 0x52, 0x2B, 0x24, 0x6B, 0x98, 0x5D};

        //
        // ISV Key: Example key delivered as part of the payload at the end of the sigma sequence.
        // This is used for demonstration purposes only, and would not necessarily be hard coded
        // in the server application.
        public static readonly byte[] isvKey = { 
        0xa4, 0x84, 0x05, 0x3c, 0x5f, 0xb0, 0xf5, 0xc4, 0xe7, 0x4f, 0xca, 0x7f, 0x92, 0xb4, 0x04, 0xe5, 
        0x56, 0x58, 0x8c, 0xed, 0x6c, 0x1a, 0xcd, 0x4e, 0xbf, 0x05, 0x3f, 0x68, 0x09, 0xf7, 0x3a, 0x93 };
        //
        // ISV Debug Key: In practice this key would be different than the production key used above,
        // so that the production key would only be actually shared with a secure production enclave.
        // This is used for demonstration purposes only, and would not necessarily be hard coded
        // in the server application.
        public static readonly byte[] isvDebugKey = { 
        0xa4, 0x84, 0x05, 0x3c, 0x5f, 0xb0, 0xf5, 0xc4, 0xe7, 0x4f, 0xca, 0x7f, 0x92, 0xb4, 0x04, 0xe5, 
        0x56, 0x58, 0x8c, 0xed, 0x6c, 0x1a, 0xcd, 0x4e, 0xbf, 0x05, 0x3f, 0x68, 0x09, 0xf7, 0x3a, 0x93 };
        //
        // ISV Cert: Example certificate delivered as part of the payload at the end of the sigma sequence.
        // This is used for demonstration purposes only, and would not necessarily be hard coded
        // in the server application.        
        public static readonly byte[] isvCert = {
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0x00, 0xfb, 0x57, 0x6f, 0x15, 
        0x3e, 0xf8, 0x41, 0x47, 0x51, 0x71, 0xed, 0x2a, 0x9b, 0x88, 0x99, 0x5b, 0x85, 0x3b, 0xdf, 0xf9, 
        0x70, 0x2a, 0x6c, 0x06, 0x3b, 0x72, 0x02, 0x32, 0xb9, 0x3a, 0x76, 0xe7, 0x1c, 0xbe, 0x1a, 0x3e, 
        0xb5, 0xb0, 0x35, 0x30, 0xd1, 0x00, 0x1c, 0x17, 0xfa, 0xb6, 0x1f, 0xda, 0xf1, 0xce, 0x2a, 0xd2, 
        0xed, 0xf1, 0x20, 0x88, 0x93, 0xb0, 0x7c, 0x34, 0x19, 0xf2, 0xea, 0x63, 0xa1, 0x73, 0xdf, 0xed, 
        0x47, 0x45, 0xdd, 0x7f, 0x51, 0x94, 0x3a, 0x25, 0x59, 0x70, 0xf7, 0x8e, 0xb4, 0x5b, 0xc1, 0x41, 
        0xdf, 0x78, 0xd5, 0x00, 0x3f, 0xa5, 0x70, 0xb8, 0xe5, 0x34, 0x11, 0xba, 0x33, 0x8c, 0xe9, 0x55, 
        0x13, 0x7a, 0xbb, 0x9a, 0xd1, 0xba, 0x6b, 0x95, 0xfa, 0x35, 0xb8, 0xb1, 0x87, 0x37, 0x15, 0x17, 
        0x86, 0xc8, 0x28, 0x05, 0x52, 0x64, 0xf6, 0x49, 0x40, 0x04, 0x3a, 0x96, 0x00, 0x01, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 
        0xfa, 0x06, 0xfa, 0x00, 0x74, 0x9b, 0x97, 0xb3, 0xc3, 0x8a, 0x8b, 0xed, 0xa6, 0x07, 0x2f, 0x45, 
        0xfb, 0x12, 0x46, 0x2e, 0xe4, 0xd9, 0xbb, 0xea, 0x01, 0x73, 0x2c, 0x3a, 0xb2, 0xa3, 0xae, 0x88, 
        0x35, 0x8b, 0x21, 0x53, 0x3d, 0x14, 0x3c, 0x3e, 0xbd, 0x08, 0x5e, 0x1a, 0x44, 0x59, 0x5f, 0xc8, 
        0x73, 0x6a, 0x1e, 0x78, 0xcd, 0x98, 0x06, 0x67, 0x9a, 0xd8, 0x82, 0x41, 0x93, 0x97, 0x89, 0xf8, 
        0x4d, 0xf1, 0x3d, 0x13, 0x69, 0x1f, 0xe2, 0x5b, 0x5b, 0xed, 0x83, 0xcc, 0x20, 0x4c, 0xa9, 0xdb, 
        0x24, 0xa3, 0xe4, 0x7e, 0x5e, 0x7d, 0x35, 0xa2, 0x38, 0x6a, 0x59, 0xf3, 0xb0, 0x4b, 0x39, 0x33, 
        0xc5, 0x35, 0xe1, 0x33, 0x24, 0x6b, 0x84, 0xf2, 0x20, 0x3a, 0x47, 0x13, 0x50, 0x48, 0x02, 0xb5, 
        0xba, 0xe6, 0xf3, 0x44, 0xf9, 0x56, 0x6e, 0xeb, 0xe3, 0x3a, 0x00, 0x28, 0x9e, 0x95, 0x18, 0x71 };
        // Store the "Magic" 8 bytes required for creating key blobs for the System.Security.Cryptography ECDH keys
        // NOTE: these values may be found in a different form in Microsoft's bcrypt.h
        public static readonly byte[] msEcdhPubMagicBa = { 0x45, 0x43, 0x4B, 0x31, 0x20, 0x00, 0x00, 0x00 };  //ECK1 curve
        public static readonly byte[] msEcdsaPubMagicBa = { 0x45, 0x43, 0x53, 0x31, 0x20, 0x00, 0x00, 0x00 }; //ECS1 Curve

        public class QuoteInfo
        {
            // Define a container for the enclave quote information
            public static int SignatureTypeOffset = 2;  // Offset in 8bit Bytes per spec.
            public static int AttributesOffset = 96;  // Offset in 8bit Bytes per spec.
            public static int AttributesSize = 16;  // mrenclave 256 bit size in bytes
            public static int mrEncOffset = 112;  // Offset in 8bit Bytes per spec.
            public static int mrEncSize = 32;  // mrenclave 256 bit size in bytes
            public static int MRSIGNEROffset = 176;  // Offset in 8bit Bytes per spec.
            public static int MRSIGNERSize = 32;  // mrenclave 256 bit size in bytes
            public static int ISVSVNOffset = 306; // Offset in 8bit Bytes per spec.
            public static int ISVPRODIDOffset = 304; // Offset in 8bit Bytes per spec.
            public static int reportDataOffset = 368; // Offset in 8bit Bytes per spec.
            public static int reportDataSize = 32; // size of the non-zero portion of the REPORTDATA field per spec.
            public static byte[] Attributes = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            public static byte[] SignatureType = { 0xFF, 0xFF };
            public static int tlvLength = 8;
        }

    }
    ///////////////////////////////////////////////////////////////////////////
    //
    // Message Related Constants and Enums
    //
    ///////////////////////////////////////////////////////////////////////////
    //
    // enumeration for RA request/response types
    // NOTE: this definition is not backwards compatible to versions before SGX SDK 1.6
    public enum enMsgType : uint
    {
        raReserved = 0x0100,                 // Reserved for testing or future use 
        raProvisionReq = 0x0101,             // Provisioning Request from ISV app
        raChallengeResp = 0x0102,            // Challenge Response from RA server
        raMessage0Req = 0x0103,              // Msg0 from ISV app
        raMessage0Resp = 0x0104,             // Msg0 from RA server
        raMessage1Req = 0x0105,              // Msg1 from ISV app
        raMessage2Resp = 0x0106,             // Msg2 from RA server
        raMessage3Req = 0x0107,              // Msg3 from ISV app
        raIsvPayloadResp = 0x0108             // ISV Payload Response message from RA server
    };

    // default message length values for the base16 message representation used for validation
    public enum enDefaultLength : uint
    {
        raDefaultPreqLength = 0x1C,          // Provisioning Request from ISV app
        raDefaultCrespLength = 0x30,         // Challenge Response from RA server
        raDefaultM0ReqLength = 0x20,         // Msg0 from ISV app
        raDefaultM0RespLength = 0x20,        // Msg0 from RA server
        raDefaultM1Length = 0x60,            // Msg1 from ISV app
        raDefaultM2Length = 0xC8,            // Msg2 from RA server
        raDefaultM3Length = 0x5D0,           // Msg3 from ISV app
        raDefaultM4Length = 0x1FC,           // ISV Payload Response message from RA server
        raDefaultEmptyLength = 0xFFFFFFFF    // For deserialization validation
    };

    // error/status codes - NOTE that Success should be the only code returned in the sigma sequence
    // other than errors from the IAS backend.  Other error conditions terminate the sequence.
    public enum enStatusCodes : uint
    {
        raErrNone = 0x00,                    // 00, Success
        raErrReqRejected = 0x01,             // 01, External error, ALL  - request message was rejected
        raErrInternal = 0x02,                // 03, Internal error, for debug only
        raErrUnknown = 0x03,                 // 04, Internal error, a handshake error that is not expected.
        raErrMeasurement = 0x10,             // 10, Enclave measurement mismatch error from SP RA server
        raErrKeyCheckFail = 0x11,            // 11, SP RA server error checking ga in Msg3
        raErrCmacCheckFail = 0x12,           // 12, SP RA server error checking CMACsmk in Msg3
        raErrQuoteCheckFail = 0x13,          // 13, SP RA server error checking Quote in Msg3
        raErrREPORTDATACheckFail = 0x14,     // 14, SP RA server error checking REPORTDATA field for Msg3 replay
        raErrVerificationSigCheckFail = 0x15,// 15, SP RA server error checking verification report signature from IAS
        raErrIasGetSuccess = 0xC8,           // C8, (decimal 200) GET Operation success from IAS
        raErrIasCreated = 0xC9,              // C9, (decimal 201) Create Report successful from IAS
        raErrIasBadRequest = 0x190,          // 190, (decimal 400) Invalid Evidence Payload from IAS
        raErrIasUnauth = 0x191,              // 191, (decimal 401) Unauthorized response from IAS
        raErrIasNotFound = 0x194,            // 194, (decimal 404) Not Found response from IAS
        raErrIasInternal = 0x1F4,            // 1F4, (decimal 500) Internal Error from IAS
        raErrIasUnknown = 0x208              // 208, (decimal 520) Unknown IAS Error or Connection Error
    }

    public class MsgFieldLimits
    {
        public const UInt32 UINT32_PRACTICAL_SIZE_LIMIT = 0xC00000;
        public const UInt32 UINT32_MINIMUM_QUOTE_SIZE = 0x000001B4; // This value should correspond to the quote structure size in the SGX SDK
    }


    //
    public class MsgInitValues
    {
        public static byte[] EmptyArray = Encoding.ASCII.GetBytes(new string('0', Constants.PSEManifestLen));
        public static byte[] PROTOCOL = { 0x02, 0x00 };
        public static byte[] DS_ZERO_BA16 = { 0x00, 0x00, 0x00, 0x00, 0x00, 
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        // "Empty" values For deserialization validation and error messages
        public static byte[] DS_EMPTY_BYTE = { 0xFF };
        public const UInt16 DS_EMPTY_UITN16 = 0xFFFF;
        public const UInt32 DS_EMPTY_UINT32 = 0xFFFFFFFF;
        public static byte[] DS_EMPTY_NONCE = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
            0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static byte[] DS_EMPTY_BA2 = { 0xFF, 0xFF };
        public static byte[] DS_EMPTY_BA4 = { 0xFF, 0xFF, 0xFF, 0xFF };
        public static byte[] DS_EMPTY_BA8 = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static byte[] DS_EMPTY_BA12 = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
            0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static byte[] DS_EMPTY_BA32 = { 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF };
        public static byte[] DS_EMPTY_BA64 = { 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static byte[] DS_EMPTY_BA256 = { 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static byte[] DS_ZERO_BA4 = { 0x00, 0x00, 0x00, 0x00 };
        public static byte[] DS_ZERO_PIB_BA = { 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00 };
        public static byte[] DS_ZERO_BA256 =  { 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
        public static byte[] DS_ZERO_PAYLOAD_BA = {  
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
    }

}