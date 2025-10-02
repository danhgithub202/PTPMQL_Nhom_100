namespace DemoMVC.Models.Process
{
    public class GenCode
    {
        public string AutoGenCode(string id)
        {
            string newCode = string.Empty;

            if (!string.IsNullOrEmpty(id))
            {
                // Tách phần chữ và phần số
                string prefix = string.Empty;
                string numberPart = string.Empty;

                foreach (char c in id)
                {
                    if (char.IsLetter(c))
                    {
                        prefix += c; // lưu chữ
                    }
                    else if (char.IsDigit(c))
                    {
                        numberPart += c; // lưu số
                    }
                }

                // Nếu có phần số thì tăng lên
                if (!string.IsNullOrEmpty(numberPart))
                {
                    int number = int.Parse(numberPart);
                    number++;

                    // Giữ nguyên độ dài số cũ (ví dụ: "01" → "02")
                    newCode = prefix + number.ToString(new string('0', numberPart.Length));
                }
                else
                {
                    // Nếu id không có số, thì gán mặc định là 1
                    newCode = prefix + "01";
                }
            }

            return newCode;
        }
    }
}
