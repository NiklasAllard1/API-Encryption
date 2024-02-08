using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EncryptionController : ControllerBase
    {
        [HttpGet("encrypt")]
        public IActionResult Encrypt(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return BadRequest("Text cannot be empty");
            }

            string encryptedText = EncryptText(text);
            return Ok(encryptedText);
        }

        private string EncryptText(string text)
        {
            string encryptedText = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    int offset = char.IsUpper(c) ? 'A' : 'a';
                    encryptedText += (char)((((c - offset) + 3) % 26) + offset);
                }
                else
                {
                    encryptedText += c;
                }
            }
            return encryptedText;
        }
    }
}
