using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Song_Encription
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var sbf = new StringBuilder();
            while (true)
            {
                string[] data = Console.ReadLine().Split(":").ToArray();

                if (data[0] == "end")
                {
                    break;
                }

                string artist = data[0];
                string song = data[1];

                string patternArtist = @"^[A-Z]{1}[a-z\s\']+$";

                string patternSong = @"^[A-Z \s]+$";

                Match mArtist = Regex.Match(artist, patternArtist);

                Match mSong = Regex.Match(song, patternSong);

                if (mArtist.Success && mSong.Success)
                {
                    artist = mArtist.Value;
                    song = mSong.Value;

                    int num = artist.Length;

                    sb.Append(artist);
                    sb.Append("@");
                    sb.Append(song);

                    for (int i = 0; i < sb.Length; i++)
                    {
                        if ((int)sb[i] == 32)
                        {
                            sbf.Append(" ");
                        }
                        else if ((int)sb[i] == 39)
                        {
                            sbf.Append("'");
                        }
                        else if(sb[i] == '@')
                        {
                            sbf.Append("@");
                        }
                        else
                        {
                            if (sb[i] + num > 122 && char.IsLower(sb[i]))
                            {   
                                sbf.Append((char)(sb[i] + num - 122 + 96));
                            }
                            else if (sb[i] + num > 90 && char.IsUpper(sb[i]))
                            {
                                sbf.Append((char)(sb[i] + num - 90 + 64)); 
                            }
                            else
                            {
                                sbf.Append((char)(sb[i] + num));
                            }
                        }
                    }
                    string final = sbf.ToString();
                    Console.WriteLine("Successful encryption: {0}", final);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                sb.Clear();
                sbf.Clear();
            }//while ends here.
        }
    }
}
