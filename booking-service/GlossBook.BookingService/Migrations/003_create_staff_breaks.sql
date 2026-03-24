-- Migration: 003_create_staff_breaks
-- Created: 2026-03-24
-- Description: Creates staff_breaks table for break windows within a schedule

CREATE TABLE staff_breaks (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    schedule_id UUID NOT NULL REFERENCES staff_schedules(id) ON DELETE CASCADE,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    label VARCHAR(100),

    CONSTRAINT chk_break_end_after_start
        CHECK (end_time > start_time)
);

CREATE INDEX idx_staff_breaks_schedule_id
    ON staff_breaks(schedule_id);