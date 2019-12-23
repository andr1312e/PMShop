using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace PMShop.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Кофта Росатома",
                        Description = "Синяя кофта размера М",
                        Category = "Мерч",
                        Price = 2750m
                    },
                    new Product
                    {
                        Name = "Мерч от Росатома",
                        Description = "Флешка",
                        Category = "Мерч",
                        Price = 3500m
                    },
                    new Product
                    {
                        Name = "Расчетка №1",
                        Description = "Идет в комплекте с оценкой",
                        Category = "Домашка",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Расчетка №2 и №3",
                        Description = "Идут в комплекте с двумя оценками",
                        Category = "Домашка",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Книги по философии",
                        Description = "Отдам за шоколадку",
                        Category = "Философия",
                        Price = 1m
                    },
                    new Product
                    {
                        Name = "Расчетка №4",
                        Description = "Уже готовая",
                        Category = "Домашка",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Журнал Вопросы Философии",
                        Description = "Самый лучший журнал в мире",
                        Category = "Философия",
                        Price = 1480m
                    },
                    new Product
                    {
                        Name = "Комплект лекций ПМ",
                        Description = "За 7 лет",
                        Category = "Эксклюзив",
                        Price = 9999999m
                    },
                    new Product
                    {
                        Name = "Ничего",
                        Description = "Просто ничего",
                        Category = "Ничего",
                        Price = 1m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
