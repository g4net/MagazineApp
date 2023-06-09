﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public DateTime UploadDate
        {
            get;
            set;
        }

        public virtual Evaluation Evaluation
        {
            get;
            set;
        }

        public virtual ICollection<Person> CoAuthors
        {
            get;
            set;
        }


        [Required]
        public virtual User Responsible
        {
            get;
            set;
        }

        public virtual Issue Issue
        {
            get;
            set;
        }

        [Required]
        [InverseProperty("Papers")]
        public virtual Area BelongingArea
        {
            get;
            set;
        }

        [InverseProperty("EvaluationPending")]
        public virtual Area EvaluationPendingArea
        {
            get;
            set;
        }

        [InverseProperty("PublicationPending")]
        public virtual Area PublicationPendingArea
        {
            get;
            set;
        }
    }
}
