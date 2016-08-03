using UnityEngine;
using System.Collections;

public class BitfieldTest : MonoBehaviour {

    public LayerMask mask;

	void Start () {

        // Bitarray
        /*BitArray barray = new BitArray(new bool[] { true, true, false, false });
        BitArray andarray = barray.And(barray);
        BitArray orarray = barray.Or(barray);
        BitArray notarray = barray.Not();
        // BitArray xorarray = barray.Xor(barray);
        foreach (bool b in barray)
        {
            Debug.Log(b);
        }
        barray.Get(4);
        barray.Set(4, true);
        barray.SetAll(true);*/

        // Bit operations
        int bmask = 179;
        string binaryString = "";
        for (int i = 0; i < 8; i++)
        {
            int tempbyte = bmask >> i;
            bool result = (tempbyte & 1) == 1;
            string resultString = result ? "1" : "0";
            binaryString = resultString + binaryString;
        }
        Debug.Log(binaryString);

        // Bit insert
        bool[] barray = new bool[] { true, true, false, false, true, true, false, true };
        bmask = 0;
        for (int i = 0; i < 8; i++)
        {
            bool result = barray[i];
            int unoShiftato = result ? 1 << i : 0;
            bmask = bmask | unoShiftato;
        }
        Debug.Log(bmask);
    }
	
}
