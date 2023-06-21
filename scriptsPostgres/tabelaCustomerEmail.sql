-- Table: public.customeremail

-- DROP TABLE IF EXISTS public.customeremail;

CREATE TABLE IF NOT EXISTS public.customeremail
(
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    email character varying(25) COLLATE pg_catalog."default" NOT NULL,
    contato character varying(25) COLLATE pg_catalog."default" NOT NULL,
    "idExt" integer NOT NULL,
    CONSTRAINT "PK_customeremail" PRIMARY KEY (id),
    CONSTRAINT "FK_customeremail_customer_idExt" FOREIGN KEY ("idExt")
        REFERENCES public.customer (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.customeremail
    OWNER to postgres;
-- Index: IX_customeremail_idExt

-- DROP INDEX IF EXISTS public."IX_customeremail_idExt";

CREATE INDEX IF NOT EXISTS "IX_customeremail_idExt"
    ON public.customeremail USING btree
    ("idExt" ASC NULLS LAST)
    TABLESPACE pg_default;