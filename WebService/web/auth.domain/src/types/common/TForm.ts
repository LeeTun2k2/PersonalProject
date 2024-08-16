import { TFormItem } from './TFormItem';

export type TFrom = {
  fields: TFormItem[];
  title?: string;
  description?: string;
  onSubmit?: (data: Record<string, any>) => void;
  onReset?: () => void;
  submitButtonText?: string;
  resetButtonText?: string;
};