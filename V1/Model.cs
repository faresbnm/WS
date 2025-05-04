using System;


	public class Model
	{
		private string Text { get; set; }

        public string ConvertToUpper(string Text)
        {
            char[] chars = Text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'a' && chars[i] <= 'z')
                {
                    chars[i] = (char)(chars[i] - 32);
                }
            }
            return new string(chars);
        }

        public string getText()
        {
        return Text;
        }
        public void setText(string name)
        {
         Text = name;
        }

}
