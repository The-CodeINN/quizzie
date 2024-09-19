using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        string htmlContent = @"
        <!DOCTYPE html>
        <html lang='en'>
        <head>
            <meta charset='UTF-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <title>Welcome Page</title>
            <style>
                body {
                    font-family: Arial, sans-serif;
                    background-color: #f4f4f9;
                    margin: 0;
                    padding: 0;
                    display: flex;
                    justify-content: center;
                    align-items: center;
                    height: 100vh;
                    color: #333;
                }
                .container {
                    background-color: white;
                    border-radius: 8px;
                    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
                    text-align: center;
                    padding: 40px;
                    max-width: 600px;
                    width: 100%;
                }
                h1 {
                    color: #5b83e3;
                    margin-bottom: 20px;
                }
                p {
                    font-size: 18px;
                    line-height: 1.6;
                }
                .btn {
                    background-color: #5b83e3;
                    color: white;
                    border: none;
                    padding: 10px 20px;
                    border-radius: 5px;
                    text-decoration: none;
                    font-size: 16px;
                    margin-top: 20px;
                    display: inline-block;
                }
                .btn:hover {
                    background-color: #4a6fcc;
                }
            </style>
        </head>
        <body>
            <div class='container'>
                <h1>Welcome to Quizzard</h1>
                <p>
                    We're excited to have you here! This platform offers a variety of features 
                    designed to streamline your workflow and improve leraning and productivity.
                </p>
                <p>
                    Get started by exploring the dashboard or learning more about the services we provide.
                </p>
                <a href='/' class='btn'>Go to Dashboard</a>
            </div>
        </body>
        </html>";
        
        return Content(htmlContent, "text/html");
    }
}
