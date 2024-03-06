using impact.Models;
using impact.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace impact.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Service> services = new List<Service>()
            {
                new Service()
                {
                    Title = "Website Development:",
                    Description = "Design and develop stunning, user-friendly websites tailored to your brand's needs.\r\n to CodeAcademy",
                    IconName = "bi bi-browser-chrome",
                    Url = "https://google.com",
                    UrlText ="Get more information"
                },
                new Service()
                {
                    Title = "Graphic Design",
                    Description = "Create eye-catching visuals and branding materials that leave a lasting impression on your audience.\r\n",
                    IconName = "bi bi-palette",
                    Url = "https://google.com",
                    UrlText ="Get more information"
                },
                new Service()
                {
                    Title = "Mobile App Development",
                    Description = "Develop innovative mobile applications for iOS and Android platforms, enhancing accessibility and user experience.",
                    IconName = "bi bi-phone",
                    Url = "https://google.com",
                    UrlText ="Get more information"
                }

            };
            List<Testimonial> testimonials = new List<Testimonial>()
            {
                new Testimonial()
                {
                    Img ="https://islam.ru/sites/default/files/img/2017/obshestvo/uverennost-v-muzhchine_0.jpg",
                    FullName = "Ramiz Mamedov",
                    Position = "Marketing manager",
                    Detail = "Outstanding service from start to finish! This company exceeded my expectations in every way. Highly recommended for their professionalism and efficiency."
                },
                new Testimonial()
                {
                    Img ="https://vplate.ru/images/knowledge/orig/2022/11/afanasij.jpeg",
                    FullName = "Islam Elekberov",
                    Position = "Backend Developer",
                    Detail = "Exceptional company with top-notch service! Their expertise and dedication truly set them apart. Highly satisfied with the results they delivered."
                },
                new Testimonial()
                {
                    Img ="https://yt3.googleusercontent.com/ytc/APkrFKZBlizwMF5aDxchNqJzg6mWsESa3vWge8L8Byk0=s900-c-k-c0x00ffffff-no-rj",
                    FullName = "Eli Memmedov",
                    Position = "Assistant",
                    Detail = "Incredible experience with this company! Their professionalism and attention to detail made all the difference. Highly recommend for anyone seeking quality service."
                },
                new Testimonial()
                {
                    Img ="https://avatars.mds.yandex.net/i?id=a1f6ad4aed350875aeac4f938b62a78edad7fb55-12144750-images-thumbs&n=13",
                    FullName = "Nezrin Veliyeva",
                    Position = "Assistant",
                    Detail = "Absolutely thrilled with the service from this company! Their commitment to excellence and customer satisfaction is evident in every interaction. Highly recommend for anyone seeking top-tier quality."
                },
                new Testimonial()
                {
                    Img ="https://avatars.mds.yandex.net/i?id=119a717d9b74b47495a4ebd5980e010ee95e05c8-10385077-images-thumbs&n=13",
                    FullName = "Leyla Imanova",
                    Position = "Operator",
                    Detail = "Exceptional company with unmatched service! Their dedication to excellence and customer satisfaction is truly remarkable. Highly recommended for anyone in need of top-quality solutions."
                },
                new Testimonial()
                {
                    Img ="https://avatars.mds.yandex.net/i?id=1615ef85fbd088efaa80c880aec49ff0-5275490-images-thumbs&n=13",
                    FullName = "Kamil Soltanov",
                    Position = "Accountant",
                    Detail = "Outstanding company delivering exceptional service! Their professionalism and commitment to excellence are truly commendable. Highly recommended for anyone seeking reliable and top-quality solutions."
                }
            };
            HomeViewModel viewModel = new HomeViewModel()
            {
                Services = services,
                Testimonials = testimonials
                
            };

            

            return View(viewModel);
        }
    }
}
