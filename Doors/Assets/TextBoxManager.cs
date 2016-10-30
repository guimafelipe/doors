using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {
	
	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	public PlayerController player;


	// Use this for initialization
	void Start()
	{
		player = FindObjectOfType<PlayerController> ();

		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Lenght - 1;
		}

	void Update()
	{
			
		theText.text = textLines[currentLine];

	}
	
	}
}
