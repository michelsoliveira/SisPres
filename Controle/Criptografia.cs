using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Security.Cryptography;

public class Criptografia
{
    //Criptografa uma string
    public static string encrypt(string str, string key)
    {
        TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
        MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
        try
        {
            //inverte as letras da chave (TESTE -> ETSET)
            key = embaralha(key);
            //Armazena na variável DES a chave(key) com Encode MD5 
            DES.Key = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            //Aplica o Modo ECB à variável DES, isto é, blocos iguais no texto são armazenados com uma única representação 
            DES.Mode = CipherMode.ECB;
            //Cria o encryptor
            ICryptoTransform DES_encrypt = DES.CreateEncryptor();
            //Armazena em um vetor de bytes o MD5 da String str
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(str);
            //Transforma e retorna a string criptografada
            return Convert.ToBase64String(DES_encrypt.TransformFinalBlock(buffer, 0, buffer.Length));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    //Descriptografa uma string
    public static string decrypt(string str, string key)
    {
        TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
        MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
        try
        {
            //inverte as letras da chave (TESTE -> ETSET)
            key = embaralha(key);
            //Armazena na variável DES a chave(key) com Encode MD5 
            DES.Key = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            //Aplica o Modo ECB à variável DES, isto é, blocos iguais no texto são armazenados com uma única representação
            DES.Mode = CipherMode.ECB;
            // Cria o decryptor
            ICryptoTransform DES_decrypt = DES.CreateDecryptor();
            //Armazena em um vetor de bytes a String str (string ainda encryptada)
            byte[] buffer = Convert.FromBase64String(str);
            //Transforma e retorna a string descriptografada
            return ASCIIEncoding.ASCII.GetString(DES_decrypt.TransformFinalBlock(buffer, 0, buffer.Length));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    //inverte as letras de uma string(STRING -> GNIRTS) 
    //** Opcional no uso da criptografia, apenas uma segurança a mais para a chave que é passada
    private static string embaralha(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}


