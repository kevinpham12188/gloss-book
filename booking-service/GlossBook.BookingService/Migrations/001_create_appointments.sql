-- Migration: 001_create_appointments
-- Created: 2025-01-01
-- Description: Creates the appointments table for the Booking Service

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

CREATE TYPE appointment_status AS ENUM (
    'pending',
    'confirmed',
    'completed',
    'cancelled'
);

CREATE TABLE appointments (
    id                  UUID                PRIMARY KEY DEFAULT uuid_generate_v4(),
    client_id           UUID                NOT NULL,
    technician_id       UUID                NOT NULL,
    service_id          UUID                NOT NULL,
    start_time          TIMESTAMPTZ         NOT NULL,
    end_time            TIMESTAMPTZ         NOT NULL,
    status              appointment_status  NOT NULL DEFAULT 'pending',
    price_at_booking    NUMERIC(10,2)       NOT NULL,
    notes               TEXT,
    created_at          TIMESTAMPTZ         NOT NULL DEFAULT NOW(),

    CONSTRAINT chk_end_after_start 
        CHECK (end_time > start_time),
    
    CONSTRAINT chk_price_positive 
        CHECK (price_at_booking > 0)
);

CREATE INDEX idx_appointments_client_id 
    ON appointments(client_id);

CREATE INDEX idx_appointments_technician_id 
    ON appointments(technician_id);

CREATE INDEX idx_appointments_start_time 
    ON appointments(start_time);