﻿using System.Data.Entity;
using System;
using System.Collections.Generic;

namespace Dal
{
    internal class MyInitializer<T> : DropCreateDatabaseIfModelChanges<ModelBeauty>
    //CreateDatabaseIfNotExists
    //DropCreateDatabaseAlways
    {
        protected override void Seed(ModelBeauty context)
        {
            WorkPosition admin = new WorkPosition()
            {

                Name = "Admin",
                Staff = new List<Staff>()
            };
            WorkPosition employee = new WorkPosition()
            {
                Name = "Employee",
                Staff = new List<Staff>()
            };

            List<Staff> listStaff = new List<Staff>();
            Staff staff = new Staff()
            {
                Login = "1",
                Password = "1",
                WorkPosition = admin
            };
            listStaff.Add(staff);
            staff = new Staff()
            {
                Login = "3",
                Password = "3",
                WorkPosition = employee
            };
            listStaff.Add(staff);
            staff = new Staff()
            {
                Login = "2",
                Password = "2",
                WorkPosition = employee
            };
            listStaff.Add(staff);
            context.Staffs.AddRange(listStaff);
            context.SaveChanges();

            List<Material> listProductsShampoo = new List<Material>();
            Shampoo productShampoo = new Shampoo()
            {
                Name = "Keratin Shampoo",
                Brand = "Estel Professional",
                Price = 195,
                Volume = 250,
                QuantityBottles = 1,
                QuantityGeneralVolume = 250,
                Service = new List<Service>(),
                QuntityCount= 5

            };
            listProductsShampoo.Add(productShampoo);
            productShampoo = new Shampoo()
            {
                Name = "Volume Shampoo for Oily Hair",
                Brand = "Estel Professional",
                Price = 195,
                Volume = 250,
                QuantityBottles = 1,
                QuantityGeneralVolume = 250,
                Service = new List<Service>(),
                 QuntityCount = 5
            };
            listProductsShampoo.Add(productShampoo);
            context.Materials.AddRange(listProductsShampoo);

            List<Material> listProductsColor = new List<Material>();
            HairColor productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Red",
                QuantityGeneralVolume = 60,
                Service = new List<Service>(),
                QuntityCount = 60
            };
            listProductsColor.Add(productColor);

            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Chestnut",
                Description = "for gray hair",
                QuantityGeneralVolume = 60,
                Service = new List<Service>(),
                QuntityCount = 60
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Dark chestnut",
                Description = "for gray hair",
                QuantityGeneralVolume = 60,
                Service = new List<Service>(),
                QuntityCount = 60
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Light brown",
                Description = "for gray hair",
                QuantityGeneralVolume = 60,
                Service = new List<Service>(),
                QuntityCount = 60
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Golden Brown",
                QuantityGeneralVolume = 60,
                Service = new List<Service>(),
                QuntityCount = 60
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Ash Blonde",
                QuantityGeneralVolume = 60,
                Service = new List<Service>(),
                QuntityCount = 60
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Honey Blondy",
                QuantityGeneralVolume = 60,
                Service = new List<Service>(),
                QuntityCount = 60
            };
            listProductsColor.Add(productColor);
            context.Materials.AddRange(listProductsColor);

            List<Material> listProductsBalsam = new List<Material>();
            Balsam productBalsam = new Balsam()
            {
                Name = "Prima Blonde Balm",
                Brand = "Estel Professional",
                Price = 825,
                Volume = 1000,
                QuantityBottles = 1,
                QuantityGeneralVolume = 1000,
                Service = new List<Service>(),
                QuntityCount = 5

            };
            listProductsBalsam.Add(productBalsam);
            productBalsam = new Balsam()
            {
                Name = "Otium Miracle",
                Brand = "Estel Professional",
                Price = 135,
                Volume = 200,
                QuantityBottles = 1,
                QuantityGeneralVolume = 200,
                Service = new List<Service>(),
                QuntityCount = 5

            };
            listProductsBalsam.Add(productBalsam);
            productBalsam = new Balsam()
            {
                Name = "Otium iNeo-Crystal",
                Brand = "Estel Professional",
                Price = 140,
                Volume = 250,
                QuantityBottles = 1,
                QuantityGeneralVolume = 250,
                Service = new List<Service>(),
                QuntityCount = 5

            };
            listProductsBalsam.Add(productBalsam);
            context.Materials.AddRange(listProductsBalsam);

            List<Material> listProductsLaque = new List<Material>();
            Laque productLaque = new Laque()

            {
                Name = "Airex",
                Brand = "Estel Professional",
                Price = 227,
                Volume = 400,
                QuantityBottles = 1,
                QuantityGeneralVolume = 400,
                Service = new List<Service>(),
                QuntityCount = 5

            };
            listProductsLaque.Add(productLaque);
            context.Materials.AddRange(listProductsLaque);

            List<Material> listProductsFountation = new List<Material>();
            Foundation productFoundation = new Foundation()
            {
                Name = "24h Infaillible",
                Brand = "L'Oreal Paris",
                Price = 245,
                Volume = 35,
                QuantityBottles = 1,
                Color = "creamy beige",
                QuantityGeneralVolume = 35,
                Service = new List<Service>(),
                QuntityCount = 0.4

            };
            listProductsFountation.Add(productFoundation);
            productFoundation = new Foundation()
            {
                Name = "Alliance Perfect",
                Brand = "L'Oreal Paris",
                Price = 190,
                Volume = 30,
                QuantityBottles = 1,
                Color = "golden natural",
                QuantityGeneralVolume = 30,
                Service = new List<Service>(),
                QuntityCount = 0.4

            };
            listProductsFountation.Add(productFoundation);
            context.Materials.AddRange(listProductsFountation);

            List<Material> listProductsShadow = new List<Material>();
            Shadows productsShadow = new Shadows()

            {
                Name = "Color Riche Mono",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 4.7,
                QuantityBottles = 1,
                Color = "grisante",
                QuantityGeneralVolume = 4.7,
                Service = new List<Service>(),
                QuntityCount = 0.1

            };
            listProductsShadow.Add(productsShadow);
            productsShadow = new Shadows()
            {
                Name = "Color Riche Mono",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 4.7,
                QuantityBottles = 1,
                Color = "extra-vertie",
                QuantityGeneralVolume = 4.7,
                Service = new List<Service>(),
                QuntityCount = 0.1

            };
            listProductsShadow.Add(productsShadow);
            productsShadow = new Shadows()
            {
                Name = "Color Riche Mono",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 4.7,
                QuantityBottles = 1,
                Color = "lunaire",
                QuantityGeneralVolume = 4.7,
                Service = new List<Service>(),
                QuntityCount = 0.1

            };
            listProductsShadow.Add(productsShadow);
            productsShadow = new Shadows()
            {
                Name = "Color Riche Mono",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 4.7,
                QuantityBottles = 1,
                Color = "emauvante",
                QuantityGeneralVolume = 4.7,
                Service = new List<Service>(),
                QuntityCount = 0.1

            };
            listProductsShadow.Add(productsShadow);
            context.Materials.AddRange(listProductsShadow);

            List<Material> listProductLipstick = new List<Material>();
            Lipstick productLipstick = new Lipstick()

            {
                Name = "Intense Lipstick",
                Brand = "L'Oreal Paris",
                Price = 261,
                Volume = 4.2,
                QuantityBottles = 1,
                Color = "classic passion",
                QuantityGeneralVolume = 4.2,
                Service = new List<Service>(),
                QuntityCount = 0.1

            };
            listProductLipstick.Add(productLipstick);
            productLipstick = new Lipstick()
            {
                Name = "Intense Lipstick",
                Brand = "L'Oreal Paris",
                Price = 261,
                Volume = 4.2,
                QuantityBottles = 1,
                Color = "magnetic coral",
                QuantityGeneralVolume = 4.2,
                Service = new List<Service>(),
                QuntityCount = 0.1

            };
            listProductLipstick.Add(productLipstick);
            context.Materials.AddRange(listProductLipstick);


            List<Material> listProductPowder = new List<Material>();
            Powder productPowder = new Powder()

            {
                Name = "Infallible Powder",
                Brand = "L'Oreal Paris",
                Price = 280,
                Volume = 9,
                QuantityBottles = 1,
                Color = "warm vanilla",
                QuantityGeneralVolume = 9,
                Service = new List<Service>(),
                QuntityCount = 0.1

            };
            listProductPowder.Add(productPowder);
            productPowder = new Powder()
            {
                Name = "Infallible Powder",
                Brand = "L'Oreal Paris",
                Price = 280,
                Volume = 9,
                QuantityBottles = 1,
                Color = "sand beige",
                QuantityGeneralVolume = 9,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductPowder.Add(productPowder);
            productPowder = new Powder()
            {
                Name = "Infallible Powder",
                Brand = "L'Oreal Paris",
                Price = 280,
                Volume = 9,
                QuantityBottles = 1,
                Color = "warm sand",
                QuantityGeneralVolume = 9,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductPowder.Add(productPowder);
            context.Materials.AddRange(listProductPowder);

            List<Material> listProductMascara = new List<Material>();
            Mascara productMascara = new Mascara()

            {
                Name = "Volumissime Mascara",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 7.5,
                QuantityBottles = 1,
                QuantityGeneralVolume = 7.5,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductMascara.Add(productMascara);
            context.Materials.AddRange(listProductMascara);

            List<Material> listProductsBase = new List<Material>();
            NailBase productBase = new NailBase()

            {
                Name = "Professional Rubber Base",
                Brand = "Kodi ",
                Price = 185,
                Volume = 14,
                QuantityBottles = 1,
                QuantityGeneralVolume = 14,
                Service = new List<Service>(),
                QuntityCount = 0.1

            };
            listProductsBase.Add(productBase);
            context.Materials.AddRange(listProductsBase);

            List<Material> listProductTop = new List<Material>();
            NailTop productTop = new NailTop()

            {
                Name = "Professional Rubber Top",
                Brand = "Kodi ",
                Price = 185,
                Volume = 14,
                QuantityBottles = 1,
                QuantityGeneralVolume = 14,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductTop.Add(productTop);
            context.Materials.AddRange(listProductTop);

            List<Material> listProductPolish = new List<Material>();
            NailPolish productPolish = new NailPolish()

            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "wild nude",
                QuantityGeneralVolume = 12,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "marshmallow",
                QuantityGeneralVolume = 12,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "pink diamond",
                QuantityGeneralVolume = 12,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "chubby cheeks",
                QuantityGeneralVolume = 12,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "grenatium",
                QuantityGeneralVolume = 12,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "amethyst noir",
                QuantityGeneralVolume = 12,
                Service = new List<Service>(),
                QuntityCount = 0.1
            };
            listProductPolish.Add(productPolish);
            context.Materials.AddRange(listProductPolish);
            context.SaveChanges();
            List<Material> listfromManicure = new List<Material>();
            listfromManicure.AddRange(listProductPolish);
            listfromManicure.AddRange(listProductTop);
            listfromManicure.AddRange(listProductsBase);
            List<Material> listFromHairCut = new List<Material>();
            listFromHairCut.AddRange(listProductsShampoo);
            listFromHairCut.AddRange(listProductsLaque);
            listFromHairCut.AddRange(listProductsBalsam);
            List<Material> listfromMakeUp = new List<Material>();
            listfromMakeUp.AddRange(listProductLipstick);
            listfromMakeUp.AddRange(listProductMascara);
            listfromMakeUp.AddRange(listProductPowder);
            listfromMakeUp.AddRange(listProductsFountation);
            listfromMakeUp.AddRange(listProductsShadow);
            List<Material> listfromColoring = new List<Material>();
            listfromColoring.AddRange(listProductsShampoo);
            listfromColoring.AddRange(listProductsColor);
            listfromColoring.AddRange(listProductsBalsam);
            listfromColoring.AddRange(listProductsLaque);
            Service hairCut = new Service()
            {
                Name = "HairCut",
                Price = 80,
                Materials = listFromHairCut
            };
            Service hairColor = new Service()
            {
                Name = "HairColoring",
                Price = 400,
                Materials= listfromColoring
            };
            Service makeUp = new Service()
            {
                Name = "MakeUp",
                Price = 300,
                Materials= listfromMakeUp
            };
            Service manicure = new Service()
            {
                Name = "Manicure",
                Price = 170,
                Materials = listfromManicure
            };
            context.Services.AddRange(new List<Service> { hairCut, hairColor, makeUp, manicure });
            context.SaveChanges();
        }


    }
}