-- Migration: 002_create_staff_schedules
-- Create: 2026-03-24
-- Description: Creates staff_schedules table for recurring weekly availability

CREATE TABLE staff_schedules (
    id          UUID        PRIMARY KEY DEFAULT uuid_generate_v4(),
    technician_id   UUID    NOT NULL,
    day_of_week     INT     NOT NULL,
    start_time      TIME    NOT NULL,
    end_time        TIME    NOT NULL,
    is_active       BOOLEAN     NOT NULL DEFAULT TRUE,

    CONSTRAINT chk_day_of_week
        CHECK (day_of_week BETWEEN 0 AND 6),

    CONSTRAINT chk_end_after_start
        CHECK (end_time > start_time),

    CONSTRAINT uq_technician_day
        UNIQUE (technician_id, day_of_week)
);

CREATE INDEX idx_staff_schedules_technician_id
    ON staff_schedules(technician_id)