-- Table: public.customer

-- DROP TABLE IF EXISTS public.customer;

CREATE TABLE IF NOT EXISTS public.customer
(
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    name character varying(25) COLLATE pg_catalog."default" NOT NULL,
    telephone character varying(25) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "PK_customer" PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.customer
    OWNER to postgres;