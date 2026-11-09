using PortfolioApi.Models;

namespace PortfolioApi.Services;

public class PortfolioDataService : IPortfolioDataService
{
    public PortfolioDataService()
    {
        foreach (var category in _skills)
        {
            foreach (var item in category.Items)
            {
                item.ProjectCount = _projects.Count(p => p.Tags.Any(tag => NamesMatch(item.Name, tag)));
            }
        }
    }

    private static bool NamesMatch(string skillName, string tag)
    {
        return tag.Contains(skillName, StringComparison.OrdinalIgnoreCase)
            || skillName.Contains(tag, StringComparison.OrdinalIgnoreCase);
    }

    private readonly Profile _profile = new()
    {
        FirstName = "Raquel",
        LastName = "Sanchez",
        Title = "Junior Software Engineer",
        Summary = "I build clean, responsive, and user-friendly web applications using modern technologies. " +
                  "I'm passionate about solving problems, learning continuously, and turning ideas into practical solutions.",
        Email = "raquelsanlanticse06@gmail.com",
        Location = "Cebu, Philippines",
        GitHubUrl = "https://github.com/Sanchezu2000",
        LinkedInUrl = "https://www.linkedin.com/",
        CvUrl = "cv/SANCHEZ_CV.pdf"
    };

    private readonly List<Project> _projects = new()
    {
        new Project
        {
            Id = 1,
            Title = "HRCONNECT – Agentic RAG HR Information System",
            Description = "HRCONNECT is a modern Human Resource Information System (HRIS) designed to streamline and automate essential HR processes within an organization. The system provides a centralized platform for managing employee information, leave requests and approvals, attendance, HR records, and other key workforce-related activities.",
            Tags = new() { "Next.js", "FastAPI", "LangChain", "SQL Server", "JWT" },
            ImageUrl = "images/projects/hrconnect.png",
            GitHubUrl = "https://github.com/Sanchezu2000/HRConnect",
            LiveUrl = "#"
        },
        new Project
        {
            Id = 4,
            Title = "Asset Management System ",
            Description = "The Asset Management System is a web-based application designed to simplify the tracking, monitoring, and management of organizational assets. It provides a centralized platform for recording asset information, assigning assets to employees or departments, monitoring asset status, and maintaining accurate asset records.",
            Tags = new() { "React", "ASP.NET", "SQL Server Express" },
            ImageUrl = "images/projects/asset-management.png",
            GitHubUrl = "#",
            LiveUrl = "#",
            LiveLabel = "Live Site"
        },
        new Project
        {
            Id = 5,
            Title = "Ai-Timan",
            Description = "The AI-Timan System is a modern healthcare application designed to streamline the outpatient care process by improving the management of patient information, consultations, and clinical workflows.",
            Tags = new() { "PHP", "Laravel", "React" },
            ImageUrl = "images/projects/ai-timan.png",
            GitHubUrl = "https://github.com/Sanchezu2000/Ai-Timan",
            LiveUrl = "#"
        },
        new Project
        {
            Id = 2,
            Title = "Mini List Inventory",
            Description = "The Mini Inventory System is a web-based application designed to simplify and automate the management of products, inventory, and stock movements. It provides a centralized platform where users can add and update products, monitor stock levels, record incoming and outgoing inventory, and maintain accurate inventory records.",
            Tags = new() { "React", "Tailwind CSS", "ASP.NET", "JWT", "SQL Server Express" },
            ImageUrl = "images/projects/mini-list-inventory.svg",
            GitHubUrl = "https://github.com/Sanchezu2000/MiniListInventorySystem",
            LiveUrl = "#"
        },
        new Project
        {
            Id = 3,
            Title = "Task Manager",
            Description = "The Task Management Application is a web-based system designed to help users efficiently create, organize, track, and manage tasks. It provides a centralized platform where users can set task details, assign priorities, update task statuses, monitor deadlines, and track overall progress.",
            Tags = new() { "React", "Vite", "ASP.NET", "SQL Server Express" },
            ImageUrl = "images/projects/task-manager.svg",
            GitHubUrl = "https://github.com/Sanchezu2000/TaskApp",
            LiveUrl = "#"
        },
        new Project
        {
            Id = 6,
            Title = "Star Bee Printing",
            Description = "The Joken Star Bee Printing Booking System is a web-based application designed to streamline the booking and management of printing services. It allows customers to conveniently submit printing requests, select available services, provide order details, and track the status of their bookings.",
            Tags = new() { "ASP.NET MVC", "React", "MongoDB" },
            ImageUrl = "images/projects/star-bee-printing.png",
            GitHubUrl = "#",
            LiveUrl = "#"
        }
    };

    private readonly List<ManagedProject> _hepherionLabsProjects = new()
    {
        new ManagedProject
        {
            Id = 3,
            Title = "Online Marketplace Platform",
            Description = "Managed the end-to-end delivery of a multi-vendor online marketplace where sellers list products and buyers browse, order and pay. Coordinated developers, QA and stakeholders from requirements through launch and ongoing releases.",
            Status = "Live",
            Tags = new() { "Project Management", "E-commerce", "Agile", "Product Roadmap" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "Live Site"
        },
        new ManagedProject
        {
            Id = 6,
            Title = "CRM + Sales Automation System",
            Description = "Sales System: Sales command center that manages every lead from first touch to closed-won: visual pipeline, rule-based lead scoring, follow-up reminders, proposal generation, email logging, customer history and sales analytics.",
            Status = "Live",
            Color = "#f97316",
            Color2 = "#ef4444",
            Tags = new() { "Project Management", "CRM", "Sales", "Pipeline", "Analytics" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 5,
            Title = "AI Business Automation Platform",
            Description = "AI Platform: One platform that automates repetitive work for small teams: AI chatbot, AI email assistant, document and invoice generation, visual workflow automation, internal knowledge base and AI-written reports. Built for SMEs, agencies, accounting and law firms.",
            Status = "Live",
            Color = "#7c3aed",
            Color2 = "#a78bfa",
            Tags = new() { "Project Management", "AI", "Automation", "Chatbot", "Workflow" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 4,
            Title = "Digital Payroll System",
            Description = "Fintech: Payroll built for construction sites and daily-wage teams: crew roster with daily rates, pay runs for any period, deduction handling per worker, and one-click GCash / PayMaya disbursement with reference codes. Part of the marketplace's ready-made systems, priced at",
            Status = "Live",
            Color = "#0f9d8a",
            Color2 = "#3b82f6",
            Tags = new() { "Project Management", "Fintech", "GCash", "PayMaya", "Payroll" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 7,
            Title = "Booking & Appointment Management",
            Description = "Scheduling: Built for businesses that run on appointments: online booking calendar synced with staff schedules, SMS reminders, waitlist auto-promotion, payments and customer profiles. Suited to clinics, salons, spas, gyms and coaches.",
            Status = "Live",
            Color = "#4f46e5",
            Color2 = "#7c3aed",
            Tags = new() { "Project Management", "Booking", "Scheduling", "SMS", "Payments" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 8,
            Title = "HR & Employee Management",
            Description = "HR System: Full employee lifecycle: staff directory, daily attendance with late/absent tracking, leave requests and approvals, recruitment with AI resume screening, and performance reviews. Payroll totals feed the Digital Payroll app.",
            Status = "Live",
            Color = "#6d5bd0",
            Color2 = "#14b8a6",
            Tags = new() { "Project Management", "HR", "AI", "Recruitment", "Attendance" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 9,
            Title = "AI Knowledge & Document Management",
            Description = "Knowledge System: Secure home for company knowledge: document storage, SOPs and contracts with an AI assistant that answers with source citations, OCR, version control, folder permissions, approval workflows, digital signatures, audit logs and backup.",
            Status = "Live",
            Color = "#9333ea",
            Color2 = "#14b8a6",
            Tags = new() { "Project Management", "AI", "OCR", "Document Management", "Audit Logs" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 10,
            Title = "School Management System",
            Description = "Education System: All-in-one school platform: student records and enrolment, attendance, online grading, tuition and fee payments, LMS materials, plus parent portal and teacher dashboard. For schools, universities and training centers.",
            Status = "Live",
            Color = "#6366f1",
            Color2 = "#d9a21b",
            Tags = new() { "Project Management", "Education", "LMS", "Grading", "Payments" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 11,
            Title = "Healthcare Management System",
            Description = "Health System: Clinic operations from one chart: patient records, appointments, medical history, prescriptions, laboratory, billing and an AI triage assistant that supports (never replaces) the clinician.",
            Status = "Live",
            Color = "#0e9aa7",
            Color2 = "#4f46e5",
            Tags = new() { "Project Management", "Healthcare", "AI", "Billing", "Laboratory" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 12,
            Title = "Car Rental Management System",
            Description = "Fleet & Rental: Online reservations, fleet management with GPS tracking, vehicle availability, driver verification, rental agreements, damage inspection, payment processing, maintenance scheduling and revenue analytics.",
            Status = "Live",
            Color = "#5b3fa0",
            Color2 = "#ea7a1f",
            Tags = new() { "Project Management", "Fleet", "GPS", "Rentals", "Analytics" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        },
        new ManagedProject
        {
            Id = 13,
            Title = "Laundry & Dry Cleaning Management System",
            Description = "Laundry System: Order management from drop-off to delivery: pickup and delivery scheduling, per-garment tracking with barcodes, customer notifications, payments, loyalty program, sales reports and mobile app.",
            Status = "Live",
            Color = "#0ea5e9",
            Color2 = "#38bdf8",
            Tags = new() { "Project Management", "Laundry", "Barcode", "Loyalty", "Mobile App" },
            LiveUrl = "https://vluboweb-001-site1.ltempurl.com/#marketplace",
            LiveLabel = "View on Marketplace"
        }
    };

    private readonly List<SkillCategory> _skills = new()
    {
        new SkillCategory
        {
            Title = "Frontend Development",
            Icon = "code",
            Items = new()
            {
                new SkillItem { Name = "Angular", IconType = "cdn", Icon = "angular" },
                new SkillItem { Name = "React", IconType = "cdn", Icon = "react" },
                new SkillItem { Name = "TypeScript", IconType = "cdn", Icon = "typescript" },
                new SkillItem { Name = "JavaScript", IconType = "cdn", Icon = "javascript" },
                new SkillItem { Name = "HTML5", IconType = "cdn", Icon = "html5" },
                new SkillItem { Name = "CSS3", IconType = "cdn", Icon = "css" },
                new SkillItem { Name = "Tailwind CSS", IconType = "cdn", Icon = "tailwindcss" },
                new SkillItem { Name = "Bootstrap", IconType = "cdn", Icon = "bootstrap" }
            }
        },
        new SkillCategory
        {
            Title = "Backend Development",
            Icon = "server",
            Items = new()
            {
                new SkillItem { Name = "C#", IconType = "custom", Icon = "csharp" },
                new SkillItem { Name = ".NET", IconType = "cdn", Icon = "dotnet" },
                new SkillItem { Name = "ASP.NET Core", IconType = "cdn", Icon = "dotnet" },
                new SkillItem { Name = "RESTful APIs", IconType = "custom", Icon = "restapi" },
                new SkillItem { Name = "Entity Framework Core", IconType = "custom", Icon = "efcore" }
            }
        },
        new SkillCategory
        {
            Title = "Databases",
            Icon = "database",
            Items = new()
            {
                new SkillItem { Name = "SQL Server", IconType = "custom", Icon = "sqlserver" },
                new SkillItem { Name = "PostgreSQL", IconType = "cdn", Icon = "postgresql" },
                new SkillItem { Name = "MySQL", IconType = "cdn", Icon = "mysql" },
                new SkillItem { Name = "MongoDB", IconType = "cdn", Icon = "mongodb" }
            }
        },
        new SkillCategory
        {
            Title = "Data & Analytics",
            Icon = "chart",
            Items = new()
            {
                new SkillItem { Name = "Power BI", IconType = "custom", Icon = "powerbi" },
                new SkillItem { Name = "DAX", IconType = "custom", Icon = "dax" },
                new SkillItem { Name = "Power Query", IconType = "custom", Icon = "powerquery" },
                new SkillItem { Name = "Data Modeling", IconType = "custom", Icon = "datamodeling" },
                new SkillItem { Name = "Semantic Models", IconType = "custom", Icon = "semanticmodels" }
            }
        },
        new SkillCategory
        {
            Title = "Microsoft Fabric & Cloud",
            Icon = "cloud",
            Items = new()
            {
                new SkillItem { Name = "Microsoft Fabric", IconType = "custom", Icon = "fabric" },
                new SkillItem { Name = "OneLake", IconType = "custom", Icon = "onelake" },
                new SkillItem { Name = "Lakehouse", IconType = "custom", Icon = "lakehouse" },
                new SkillItem { Name = "Warehouse", IconType = "custom", Icon = "warehouse" },
                new SkillItem { Name = "Dataflows Gen2", IconType = "custom", Icon = "dataflows" },
                new SkillItem { Name = "Pipelines", IconType = "custom", Icon = "pipelines" },
                new SkillItem { Name = "KQL (Kusto Query Language)", IconType = "custom", Icon = "kql" },
                new SkillItem { Name = "Microsoft Azure", IconType = "custom", Icon = "azure" }
            }
        },
        new SkillCategory
        {
            Title = "DevOps & Tools",
            Icon = "tools",
            Items = new()
            {
                new SkillItem { Name = "Git", IconType = "cdn", Icon = "git" },
                new SkillItem { Name = "GitHub", IconType = "cdn", Icon = "github" },
                new SkillItem { Name = "Azure DevOps", IconType = "custom", Icon = "azuredevops" },
                new SkillItem { Name = "Docker", IconType = "cdn", Icon = "docker" },
                new SkillItem { Name = "VS Code", IconType = "custom", Icon = "vscode" }
            }
        }
    };

    private readonly List<Certificate> _certificates = new()
    {
        new Certificate
        {
            Icon = "📊",
            Title = "Microsoft Certified: Power BI Data Analyst Associate",
            Description = "Validates skills in preparing, modeling, and visualizing data with Power BI, and using DAX to deliver actionable analytics for data-driven decisions.",
            ImageUrl = "images/certificates/power-bi-data-analyst.png",
            RelatedSkills = new() { "Power BI", "DAX", "Power Query", "Data Modeling", "SQL Server" }
        },
        new Certificate
        {
            Icon = "🧩",
            Title = "Microsoft Certified: Fabric Analytics Engineer Associate",
            Description = "Validates skills in designing, building, and managing analytics solutions in Microsoft Fabric, including data pipelines, lakehouses, and semantic models.",
            ImageUrl = "images/certificates/fabric-analytics-engineer.png",
            RelatedSkills = new() { "Microsoft Fabric", "Lakehouse", "Warehouse", "Pipelines", "Semantic Models", "Microsoft Azure" }
        },
        new Certificate
        {
            Icon = "💼",
            Title = "Microsoft Certified: Dynamics 365 Business Central Developer Associate",
            Description = "Validates skills in developing, customizing, and extending Dynamics 365 Business Central using AL, including APIs, reports, and integrations.",
            ImageUrl = "images/certificates/bc-developer-associate.png",
            RelatedSkills = new() { "Dynamics 365 Business Central", "AL Language", "RDLC Reports", "SQL Server" }
        }
    };

    private readonly List<Feature> _features = new()
    {
        new Feature { Icon = "</>", Title = "Clean Code", Description = "I focus on readable, maintainable, and scalable code." },
        new Feature { Icon = "💡", Title = "Problem Solver", Description = "I enjoy turning complex requirements into practical solutions." },
        new Feature { Icon = "▣", Title = "Always Learning", Description = "I'm continuously exploring new technologies and improving my skills." }
    };

    public Profile GetProfile() => _profile;
    public IReadOnlyList<Project> GetProjects() => _projects;
    public IReadOnlyList<ManagedProject> GetHepherionLabsProjects() => _hepherionLabsProjects;
    public IReadOnlyList<SkillCategory> GetSkills() => _skills;
    public IReadOnlyList<Certificate> GetCertificates() => _certificates;
    public IReadOnlyList<Feature> GetFeatures() => _features;
}
