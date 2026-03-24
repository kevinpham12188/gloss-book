-- Migration: 004_create_staff_schedule_overrides
-- Created: 2026-03-26
-- Description: Creates staff_schedule_overrides for one-off date exceptions

CREATE TABLE staff_schedule_overrides (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    technician_id UUID NOT NULL,
    date DATE NOT NULL,
    is_available BOOLEAN NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    reason VARCHAR(255),

    CONSTRAINT chk_times_both_or_neither
        CHECK(
            (start_time IS NULL AND end_time IS NULL) OR 
            (start_time IS NOT NULL AND end_time IS NOT NULL)
        ),
    
    CONSTRAINT chek_override_end_after_start
        CHECK (end_time IS NULL OR end_time > start_time),

    CONSTRAINT uq_technician_date
        UNIQUE (technician_id, date)
);

CREATE INDEX idx_schedule_overrides_technician_date
    ON staff_schedule_overrides(technician_id, date);