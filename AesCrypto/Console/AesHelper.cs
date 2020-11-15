using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Console
{
    public static class AesHelper
    {
        private const string IV = "2wDwCbJtSVuTlXhL";
        private const string KEY = "OZMd2MfM6YuoFNLXM50FpJdjX0R9